using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Dsi.StoreManagement.Categories
{
    public class CategoryDto : AuditedEntityDto<Guid>
    {
        public string DisplayFr { get; set; }
        public string DisplayAr { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }

    }
}
