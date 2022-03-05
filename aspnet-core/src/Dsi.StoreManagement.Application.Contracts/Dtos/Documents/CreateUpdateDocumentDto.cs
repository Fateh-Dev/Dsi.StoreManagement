using System;
using Dsi.StoreManagement.Categories;
using Dsi.StoreManagement.Colors;
using Dsi.StoreManagement.Marques;
using Dsi.StoreManagement.Operations;
using Dsi.StoreManagement.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dsi.StoreManagement.Documents
{
    public class CreateUpdateDocumentDto
    {
        [StringLength(128)]
        public string DisplayFr { get; set; }
        public string DisplayAr { get; set; }
        [StringLength(128)]
        public string Description { get; set; }
        [Required]
        public string DocumentReference { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DocumentDate { get; set; } = DateTime.Now;
        [Required]
        public DocumentType DocumentType { get; set; } = DocumentType.Undefined;
        [Required]
        public OperationType OperationType { get; set; } = OperationType.Undefined;

        // Public Service Owner {get;set;}
        // Public Guid OwnerId {get;set;}
        // Public Service Source {get;set;}
        // Public Guid SourceId {get;set;}
        // Public Service Destination {get;set;}
        // Public Guid DestinationId {get;set;}

    }
}
