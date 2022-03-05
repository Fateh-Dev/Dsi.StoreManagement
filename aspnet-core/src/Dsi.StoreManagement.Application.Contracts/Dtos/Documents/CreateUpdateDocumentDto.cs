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
        public bool isValid { get; set; } = false;
        [Required]
        [DataType(DataType.Date)]
        public DateTime DocumentDate { get; set; } = DateTime.Now.Date;
        [Required]
        public DocumentType DocumentType { get; set; } = DocumentType.Undefined;
        [Required]
        public OperationType OperationType { get; set; } = OperationType.Undefined;
        public Guid? OwnerId { get; set; } = null;
        public Guid? SourceId { get; set; } = null;
        public Guid? DestinationId { get; set; } = null;

    }
}
