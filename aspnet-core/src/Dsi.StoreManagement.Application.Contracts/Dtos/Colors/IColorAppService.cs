using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dsi.StoreManagement.Colors
{
    public interface IColorAppService :
       ICrudAppService< //Defines CRUD methods
           ColorDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateColorDto> //Used to create/update a book
    {

    }
}