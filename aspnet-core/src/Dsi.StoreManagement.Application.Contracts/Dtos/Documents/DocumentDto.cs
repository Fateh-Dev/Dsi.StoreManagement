using System;
using Dsi.StoreManagement.Operations;
using Volo.Abp.Application.Dtos;

namespace Dsi.StoreManagement.Documents
{
    public class DocumentDto : AuditedEntityDto<Guid>
    {
        public string DisplayFr { get; set; }
        public string DisplayAr { get; set; }
        public string Description { get; set; }
        public string DocumentReference { get; set; }
        public DateTime DocumentDate { get; set; }
        public DocumentType DocumentType { get; set; }
        public OperationType OperationType { get; set; }
        // Public Service Owner {get;set;}
        // Public Guid OwnerId {get;set;}
        // Public Service Source {get;set;}
        // Public Guid SourceId {get;set;}
        // Public Service Destination {get;set;}
        // Public Guid DestinationId {get;set;}

    }
}
