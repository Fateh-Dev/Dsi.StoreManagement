using System;
using System.ComponentModel.DataAnnotations;

namespace Dsi.StoreManagement.Colors
{
    public class CreateUpdateColorDto
    {
        [Required]
        [StringLength(128)]
        public string DisplayFr { get; set; }
        [StringLength(128)]
        public string DisplayAr { get; set; }
        public int Order { get; set; }
        [StringLength(128)]
        public string Description { get; set; }
    }
}
