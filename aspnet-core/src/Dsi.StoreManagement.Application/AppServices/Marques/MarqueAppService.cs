using System;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dsi.StoreManagement.Marques
{
    [ApiExplorerSettings(GroupName = "Dsi_Store_Manager", IgnoreApi = false)]
    public class MarqueAppService :
        CrudAppService<
            Marque, //The Book entity
            MarqueDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateMarqueDto>, //Used to create/update a book
        IMarqueAppService //implement the IBookAppService
    {
        public MarqueAppService(IRepository<Marque, Guid> repository)
            : base(repository)
        {

        }
    }
}