using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dsi.StoreManagement.Categories;
using Dsi.StoreManagement.Colors;
using Dsi.StoreManagement.Marques;
using Dsi.StoreManagement.Models;
using Dsi.StoreManagement.Operations;
using Dsi.StoreManagement.Units;
using Volo.Abp.Application.Dtos;

namespace Dsi.StoreManagement.Products
{
    public class ProductDto : AuditedEntityDto<Guid>
    {

        public string SerialNumber { get; set; }
        public string Reference { get; set; }
        public ProductStatus Status { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public ProductConsommation ProductConsommation { get; set; }
        public Guid CategoryId { get; set; }
        public Guid ModelId { get; set; }
        public Guid MarqueId { get; set; }
        public Guid UnitId { get; set; }
        public Guid ColorId { get; set; }

        // Public Guid ActualPositionId {get;set;}
        // Public Service ActualPosition {get;set;}


    }
}
