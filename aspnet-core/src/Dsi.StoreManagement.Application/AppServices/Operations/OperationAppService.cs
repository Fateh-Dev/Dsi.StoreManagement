using System;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dsi.StoreManagement.Operations
{
    [ApiExplorerSettings(GroupName = "Dsi_Store_Manager", IgnoreApi = false)]
    public class OperationAppService :
     CrudAppService<
         Operation, //The Book entity
         OperationDto, //Used to show books
         Guid, //Primary key of the book entity
         PagedAndSortedResultRequestDto, //Used for paging/sorting
         CreateUpdateOperationDto>, //Used to create/update a book
     IOperationAppService //implement the IBookAppService
    {
        public OperationAppService(IRepository<Operation, Guid> repository)
            : base(repository)
        {

        }
    }
}