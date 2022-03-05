using System;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dsi.StoreManagement.Categories
{
    [ApiExplorerSettings(GroupName = "Dsi_Store_Manager", IgnoreApi = false)]
    public class CategoryAppService :
         CrudAppService<
             Category, //The Book entity
             CategoryDto, //Used to show books
             Guid, //Primary key of the book entity
             PagedAndSortedResultRequestDto, //Used for paging/sorting
             CreateUpdateCategoryDto>, //Used to create/update a book
         ICategoryAppService //implement the IBookAppService
    {
        public CategoryAppService(IRepository<Category, Guid> repository)
            : base(repository)
        {

        }
    }
}