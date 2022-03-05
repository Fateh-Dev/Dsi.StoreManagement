using System;
using System.Collections.Generic;
using Dsi.StoreManagement.Documents;
using Dsi.StoreManagement.Products;
using Volo.Abp.Application.Dtos;

namespace Dsi.StoreManagement.StructuresOrServices
{
    public class CreateUpdateStructureOrServiceDto
    {
        public string DisplayFr { get; set; }
        public string DisplayAr { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public Guid? ParentStructureId { get; set; }

    }
}
