using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbpDz.Core;
using AbpDz.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Data;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EntityFrameworkCore.Modeling;

using System.Linq.Dynamic.Core;

namespace AbpDz.Messaging
{

    [RemoteService]
    [ApiExplorerSettings(GroupName = "Messaging")]
    [Route("api/abpdz-Messaging/[action]")]
    public class AbpDzMessagingController : AbpController, Volo.Abp.DependencyInjection.ITransientDependency
    {
        public AbpDzMessagingController(
             AbpDzMessagingervice Messagingervice
             )
        {
            Messagingervice = Messagingervice;
        }

        public AbpDzMessagingervice Messagingervice { get; }

        [HttpGet()]
        public async Task Register()
        {

            await this.Messagingervice.RegisterClient();

        }

        [HttpGet]
        public async Task<PagedResultDto<AbpDzMessagingInfo>> GetAll(EventFilterDto f)
        {
            if (!CurrentUser.IsAuthenticated)
            {
                return new PagedResultDto<AbpDzMessagingInfo>(0, Array.Empty<AbpDzMessagingInfo>());
            }


            var Config = this.ServiceProvider.GetService(typeof(AbpDzMessagingerviceConfig)) as AbpDzMessagingerviceConfig;

            var permissions = new List<string>();
            if (f.Checked == true)
            {
                await this.Register();
            }
            if (f.UserId == null)
            {

                f.UserId = CurrentUser.Id;
            }
            else if (CurrentUser.Id != f.UserId && !await AuthorizationService.IsGrantedAsync("AbpIdentity.Users.Create"))
            {
                f.UserId = CurrentUser.Id;
            }
            foreach (var item in Config.NotifyPermissions)
            {
                if (await this.AuthorizationService.IsGrantedAsync(item.Key))
                {
                    permissions.Add(item.Key);
                }
            }
            var repo = GetRepository();
            var filterIsNull = string.IsNullOrWhiteSpace(f.Filter);
            if (!filterIsNull)
            {
                f.Filter = f.Filter.Trim();
            }
            var query = (await repo.GetDbSetAsync()).Where(k =>
                 (filterIsNull || (k.Content.Contains(f.Filter) || k.MessagingName.ToLower() == f.Filter.ToLower())) &&
                 (k.RecipientId == f.UserId || permissions.Contains(k.RecipientPermission)) &&
                 (f.StartDate.HasValue == false || (k.CreationTime >= f.StartDate)) &&
                 (f.EndDate.HasValue == false || (k.CreationTime <= f.EndDate))

                 );


            if (string.IsNullOrWhiteSpace(f.Sorting))
            {
                f.Sorting = nameof(AbpDzMessagingInfo.CreationTime) + " desc";
            }

            return new SummaryPagedResultDto<AbpDzMessagingInfo>(
                await query.CountAsync(),
                await query.OrderBy(f.Sorting).Skip(f.SkipCount).Take(f.MaxResultCount).ToListAsync()
            // await query.Where(k => k.State == AbpDzMessageState.Unread).CountAsync()

            );
        }

        private IRepository<AbpDzMessagingInfo, Guid> GetRepository()
        {
            return this.ServiceProvider.GetService(typeof(IRepository<AbpDzMessagingInfo, Guid>)) as IRepository<AbpDzMessagingInfo, Guid>;
        }

        [HttpGet()]
        [Authorize]
        public async Task Ping(bool persiste = false)
        {

            await this.Messagingervice.CreateMessaging(new AbpDzMessagingInfo(true)
            {
                // Id = Guid.NewGuid(),
                CreationTime = DateTime.Now,
                MessagingName = "Bonjour:" + DateTime.Now.ToFileTime().ToString(),
                RecipientId = CurrentUser.Id,

            }, persiste);

        }
        [HttpGet()]
        public async Task SendMsg(string msg, bool persiste)
        {

            await this.Messagingervice.CreateMessaging(new AbpDzMessagingInfo(true)
            {
                // Id = Guid.NewGuid(),
                CreationTime = DateTime.Now,
                MessagingName = "Bonjour:" + msg.ToString(),
                RecipientId = CurrentUser.Id,

            }, true);
        }

        [HttpPost()]
        public async Task Dismiss(HashSet<Guid> ids)
        {
            var repo = GetRepository();
            var items = await repo.Where(k => ids.Contains(k.Id)).ToListAsync();

            foreach (var item in items)
            {
                item.State = AbpDzMessageState.Read;
            }
            foreach (var id in ids)
            {
                await this.Messagingervice.Notify(
                      new
                      {
                          Id = id,
                          State = AbpDzMessageState.Read
                      },
                      nameof(AbpDzMessagingervice),
                      nameof(AbpDzMessagingInfo),
                      CrudOperation.Update,
                      id.ToString(),
                      null,
                      this.CurrentUser.Id);
            }
        }

    }
}