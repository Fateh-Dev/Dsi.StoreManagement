using System;
using Dsi.StoreManagement.Categories;
using Dsi.StoreManagement.Colors;
using Dsi.StoreManagement.Marques;
using Dsi.StoreManagement.Operations;
using Dsi.StoreManagement.Models;
using Volo.Abp.Domain.Entities.Auditing;
using System.Collections.Generic;

namespace Dsi.StoreManagement.Documents
{
    public class Document : FullAuditedAggregateRoot<Guid>
    {
        public string DisplayFr { get; set; }
        public string DisplayAr { get; set; }
        public string Description { get; set; }
        public string DocumentReference { get; set; }
        public DocumentType DocumentType { get; set; }
        public OperationType OperationType { get; set; }
        ICollection<Operation> ProductOperations { get; set; }

        // Public Service Owner {get;set;}
        // Public Guid OwnerId {get;set;}
        // Public Service Source {get;set;}
        // Public Guid SourceId {get;set;}
        // Public Service Destination {get;set;}
        // Public Guid DestinationId {get;set;}

    }
}
