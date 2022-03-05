using System;
using Dsi.StoreManagement.Units;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dsi.StoreManagement.Units
{
    public interface IUnitAppService :
        ICrudAppService< //Defines CRUD methods
            UnitDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateUnitDto> //Used to create/update a book
    {

    }
}