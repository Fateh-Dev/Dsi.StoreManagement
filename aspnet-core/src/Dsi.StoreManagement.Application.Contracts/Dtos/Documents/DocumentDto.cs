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
        public bool isValid { get; set; }
        public DateTime DocumentDate { get; set; }
        public DocumentType DocumentType { get; set; }
        public OperationType OperationType { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? SourceId { get; set; }
        public Guid? DestinationId { get; set; }

    }
}
