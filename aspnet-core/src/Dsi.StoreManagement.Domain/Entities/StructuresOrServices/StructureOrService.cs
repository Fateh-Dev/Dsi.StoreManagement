using System;
using System.Collections.Generic;
using Dsi.StoreManagement.Documents;
using Dsi.StoreManagement.Products;
using Volo.Abp.Domain.Entities.Auditing;

namespace Dsi.StoreManagement.StructuresOrServices
{
    public class StructureOrService : FullAuditedAggregateRoot<Guid>
    {
        public string DisplayFr { get; set; }
        public string DisplayAr { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public Guid? ParentStructureId { get; set; }
        public StructureOrService ParentStructure { get; set; }
        public virtual ICollection<Product> ProductList { get; set; }
        public virtual ICollection<Document> DocumentList { get; set; }

    }
}
