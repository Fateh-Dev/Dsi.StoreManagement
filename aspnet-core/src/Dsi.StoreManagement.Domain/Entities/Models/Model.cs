using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Dsi.StoreManagement.Models
{
    public class Model : AuditedAggregateRoot<Guid>
    {
        public string DisplayFr { get; set; }
        public string DisplayAr { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }

    }
}
