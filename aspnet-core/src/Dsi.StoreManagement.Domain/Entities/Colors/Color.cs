using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Dsi.StoreManagement.Colors
{
    public class Color : AuditedAggregateRoot<Guid>
    {
        public string DisplayFr { get; set; }
        public string DisplayAr { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }

    }
}
