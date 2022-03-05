using System;
using Dsi.StoreManagement.Units;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dsi.StoreManagement.Units
{
    [ApiExplorerSettings(GroupName = "Dsi_Store_Manager", IgnoreApi = false)]
    public class UnitAppService :
        CrudAppService<
            Unit, //The Book entity
            UnitDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateUnitDto>, //Used to create/update a book
        IUnitAppService //implement the IBookAppService
    {
        public UnitAppService(IRepository<Unit, Guid> repository)
            : base(repository)
        {

        }
    }
}