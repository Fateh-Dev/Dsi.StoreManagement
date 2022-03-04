using System;
using System.Threading.Tasks;
using AbpDz.Models;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.AspNetCore.SignalR;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore.Modeling;


namespace AbpDz.Messaging
{
    public class AbpDzMessagingHub : AbpHub
    {
        public override Task OnConnectedAsync()
        {

            return base.OnConnectedAsync();
        }
    }
}