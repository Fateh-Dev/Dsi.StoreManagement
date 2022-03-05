using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dsi.StoreManagement.Models
{
    public interface IModelAppService :
       ICrudAppService< //Defines CRUD methods
           ModelDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateModelDto> //Used to create/update a book
    {

    }
}