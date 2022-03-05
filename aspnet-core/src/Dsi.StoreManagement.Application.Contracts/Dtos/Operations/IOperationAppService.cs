using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dsi.StoreManagement.Operations
{
    public interface IOperationAppService :
    ICrudAppService< //Defines CRUD methods
        OperationDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateOperationDto> //Used to create/update a book
    {

    }
}