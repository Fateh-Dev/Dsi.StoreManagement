using System;
using System.Collections.Generic;
using Dsi.StoreManagement.Categories;
using Dsi.StoreManagement.Colors;
using Dsi.StoreManagement.Marques;
using Dsi.StoreManagement.Models;
using Dsi.StoreManagement.Operations;
using Dsi.StoreManagement.StructuresOrServices;
using Dsi.StoreManagement.Units;
using Volo.Abp.Domain.Entities.Auditing;

namespace Dsi.StoreManagement.Products
{
    public class Product : FullAuditedAggregateRoot<Guid>
    {
        public string SerialNumber { get; set; }
        public string Reference { get; set; }
        public ProductStatus Status { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public ProductConsommation ProductConsommation { get; set; }
        public Category Category { get; set; }
        public Guid? CategoryId { get; set; }
        public Model Model { get; set; }
        public Guid? ModelId { get; set; }
        public Marque Marque { get; set; }
        public Guid? MarqueId { get; set; }
        public Unit Unit { get; set; }
        public Guid? UnitId { get; set; }
        public Color Color { get; set; }
        public Guid? ColorId { get; set; }
        public Guid? ActualPositionId { get; set; }
        public StructureOrService ActualPosition { get; set; }
        public Guid? OldPositionId { get; set; }
        public StructureOrService OldPosition { get; set; }
        public virtual ICollection<Operation> OperationList { get; set; }

        public void setConsommableQuantity()
        {
            if (this.ProductConsommation == ProductConsommation.NonConsommable)
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
