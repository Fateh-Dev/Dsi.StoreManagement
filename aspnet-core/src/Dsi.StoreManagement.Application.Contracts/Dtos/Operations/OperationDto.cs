using System;
using System.ComponentModel.DataAnnotations;
using Dsi.StoreManagement.Categories;
using Dsi.StoreManagement.Colors;
using Dsi.StoreManagement.Documents;
using Dsi.StoreManagement.Marques;
using Dsi.StoreManagement.Models;
using Dsi.StoreManagement.Products;
using Volo.Abp.Application.Dtos;

namespace Dsi.StoreManagement.Operations
{
    public class OperationDto : AuditedEntityDto<Guid>
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
        public Guid DocumentId { get; set; }

    }
}
