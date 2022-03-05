using System;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dsi.StoreManagement.StructuresOrServices
{
    [ApiExplorerSettings(GroupName = "Dsi_Store_Manager", IgnoreApi = false)]

    public class StructureOrServiceAppService :
      CrudAppService<
          StructureOrService, //The Book entity
          StructureOrServiceDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateStructureOrServiceDto>, //Used to create/update a book
      IStructureOrServiceAppService //implement the IBookAppService
    {
        public StructureOrServiceAppService(IRepository<StructureOrService, Guid> repository)
            : base(repository)
        {

        }
    }
}