using System;
using Dsi.StoreManagement.Categories;
using Dsi.StoreManagement.Colors;
using Dsi.StoreManagement.Documents;
using Dsi.StoreManagement.Marques;
using Dsi.StoreManagement.Models;
using Dsi.StoreManagement.Products;
using Volo.Abp.Domain.Entities.Auditing;

namespace Dsi.StoreManagement.Operations
{
    public class Operation : FullAuditedAggregateRoot<Guid>
    {
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Guid ProductId { get; set; }
        public Document Document { get; set; }
        public Guid DocumentId { get; set; }


    }
}
