using System;
using Dsi.StoreManagement.Categories;
using Dsi.StoreManagement.Colors;
using Dsi.StoreManagement.Marques;
using Dsi.StoreManagement.Models;
using Dsi.StoreManagement.Units;
using Volo.Abp.Domain.Entities.Auditing;

namespace Dsi.StoreManagement.Products
{
    public class Product : FullAuditedAggregateRoot<Guid>
    {
        public string DisplayFr { get; set; }
        public string DisplayAr { get; set; }
        public ProductStatus Status { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public ProductConsummation ProductConsummation { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
        public Model Model { get; set; }
        public Guid ModelId { get; set; }
        public Marque Marque { get; set; }
        public Guid MarqueId { get; set; }
        public Unit Unit { get; set; }
        public Guid UnitId { get; set; }
        public Color Color { get; set; }
        public Guid ColorId { get; set; }

        // Public Guid ActualPositionId {get;set;}
        // Public Service ActualPosition {get;set;}

        public void setConsommableQuantity()
        {
            if (this.ProductConsummation == ProductConsummation.NonConsommable)
            {
                this.Quantity = 1;
            }
        }

    }
}
