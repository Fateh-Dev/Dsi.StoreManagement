using System;
using Dsi.StoreManagement.Categories;
using Dsi.StoreManagement.Colors;
using Dsi.StoreManagement.Marques;
using Dsi.StoreManagement.Operations;
using Dsi.StoreManagement.Models;
using Volo.Abp.Domain.Entities.Auditing;
using System.Collections.Generic;
using Dsi.StoreManagement.StructuresOrServices;

namespace Dsi.StoreManagement.Documents
{
    public class Document : FullAuditedAggregateRoot<Guid>
    {

        public Document()
        {
            ProductList = new HashSet<Operation>();
        }
        public string DisplayFr { get; set; }
        public string DisplayAr { get; set; }
        public string Description { get; set; }
        public bool isValid { get; set; }
        public string DocumentReference { get; set; }
        public DateTime DocumentDate { get; set; }
        public DocumentType DocumentType { get; set; }
        public OperationType OperationType { get; set; }
        public ICollection<Operation> ProductList { get; set; }
        public StructureOrService Owner { get; set; }
        public Guid? OwnerId { get; set; }
        public StructureOrService Source { get; set; }
        public Guid? SourceId { get; set; }
        public StructureOrService Destination { get; set; }
        public Guid? DestinationId { get; set; }

    }
}
