using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dsi.StoreManagement.Marques
{
    public interface IMarqueAppService :
        ICrudAppService< //Defines CRUD methods
            MarqueDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateMarqueDto> //Used to create/update a book
    {

    }
}