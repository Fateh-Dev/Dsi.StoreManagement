using System;
using System.ComponentModel.DataAnnotations;
using Dsi.StoreManagement.Categories;
using Dsi.StoreManagement.Colors;
using Dsi.StoreManagement.Documents;
using Dsi.StoreManagement.Marques;
using Dsi.StoreManagement.Models;
using Dsi.StoreManagement.Products;

namespace Dsi.StoreManagement.Operations
{
    public class CreateUpdateOperationDto
    {
        [StringLength(128)]

        public string Description { get; set; }
        public int Quantity { get; set; } = 1;
        public float UnitPrice { get; set; } = 0;
        public Guid ProductId { get; set; }
        public Guid DocumentId { get; set; }

    }
}
