using System;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dsi.StoreManagement.Models
{
    [ApiExplorerSettings(GroupName = "Dsi_Store_Manager", IgnoreApi = false)]
    public class ModelAppService :
        CrudAppService<
            Model, //The Book entity
            ModelDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateModelDto>, //Used to create/update a book
        IModelAppService //implement the IBookAppService
    {
        public ModelAppService(IRepository<Model, Guid> repository)
            : base(repository)
        {

        }
    }
}