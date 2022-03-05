using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dsi.StoreManagement.Categories;
using Dsi.StoreManagement.Colors;
using Dsi.StoreManagement.Marques;
using Dsi.StoreManagement.Models;
using Dsi.StoreManagement.Operations;
using Dsi.StoreManagement.Units;

namespace Dsi.StoreManagement.Products
{
    public class CreateUpdateProductDto
    {
       
        [StringLength(128)]
        public string DisplayFr { get; set; }
        [StringLength(128)]
        public string DisplayAr { get; set; }
        public ProductStatus Status { get; set; } = ProductStatus.Undefined;
        [StringLength(128)]
        public string Description { get; set; }
        public int Quantity { get; set; } = 1;
        public ProductConsummation ProductConsummation { get; set; } = ProductConsummation.Undefined;
        public Guid CategoryId { get; set; }
        public Guid ModelId { get; set; }
        public Guid MarqueId { get; set; }
        public Guid UnitId { get; set; }
        public Guid ColorId { get; set; }

        // Public Guid ActualPositionId {get;set;}
        // Public Service ActualPosition {get;set;}


    }
}
