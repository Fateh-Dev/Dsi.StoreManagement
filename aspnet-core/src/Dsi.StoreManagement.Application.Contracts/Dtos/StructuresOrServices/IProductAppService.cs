using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dsi.StoreManagement.StructuresOrServices
{
    public interface IStructureOrServiceAppService :
        ICrudAppService< //Defines CRUD methods
            StructureOrServiceDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateStructureOrServiceDto> //Used to create/update a book
    {

    }
}