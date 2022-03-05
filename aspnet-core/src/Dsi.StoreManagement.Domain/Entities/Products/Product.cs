using System;
using System.Collections.Generic;
using Dsi.StoreManagement.Categories;
using Dsi.StoreManagement.Colors;
using Dsi.StoreManagement.Marques;
using Dsi.StoreManagement.Models;
using Dsi.StoreManagement.Operations;
using Dsi.StoreManagement.Units;
using Volo.Abp.Domain.Entities.Auditing;

namespace Dsi.StoreManagement.Products
{
    public class Product : FullAuditedAggregateRoot<Guid>
    {
        public Product(string displayFr, string displayAr, ProductStatus status, string description, int quantity, ProductConsummation productConsummation, Guid categoryId, Guid modelId, Guid marqueId, Guid unitId, Guid colorId)
        {
            this.DisplayFr = displayFr;
            this.DisplayAr = displayAr;
            this.Status = status;
            this.Description = description;
            this.Quantity = quantity;
            this.ProductConsummation = productConsummation;
            this.CategoryId = categoryId;
            this.ModelId = modelId;
            this.MarqueId = marqueId;
            this.UnitId = unitId;
            this.ColorId = colorId;
        }
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
        public virtual ICollection<Operation> OperationList { get; set; }


        // Public Guid ActualPositionId {get;set;}
        // Public Service ActualPosition {get;set;}

        public void setConsommableQuantity()
        {
            if (this.ProductConsummation == ProductConsummation.NonConsommable)
            {
                this.Quantity = 1;
            }
        }
        public void setAvailability()
        {
            if (this.Quantity == 0)
            {
                this.Status = ProductStatus.NotAvailable;
            }
        }

    }
}
