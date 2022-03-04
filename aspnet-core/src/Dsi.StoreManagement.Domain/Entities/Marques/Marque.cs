using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Dsi.StoreManagement.Marques
{
    public class Marque : AuditedAggregateRoot<Guid>
    {
        public string DisplayFr { get; set; }
        public string DisplayAr { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }

    }
}
