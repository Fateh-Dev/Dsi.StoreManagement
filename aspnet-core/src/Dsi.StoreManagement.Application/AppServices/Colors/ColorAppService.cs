using System;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dsi.StoreManagement.Colors
{
    [ApiExplorerSettings(GroupName = "Dsi_Store_Manager", IgnoreApi = false)]
    public class ColorAppService :
          CrudAppService<
              Color, //The Book entity
              ColorDto, //Used to show books
              Guid, //Primary key of the book entity
              PagedAndSortedResultRequestDto, //Used for paging/sorting
              CreateUpdateColorDto>, //Used to create/update a book
          IColorAppService //implement the IBookAppService
    {
        public ColorAppService(IRepository<Color, Guid> repository)
            : base(repository)
        {

        }
    }
}