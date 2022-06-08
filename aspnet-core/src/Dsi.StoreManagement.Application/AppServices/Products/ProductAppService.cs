using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Dsi.StoreManagement.Products
{

    [ApiExplorerSettings(GroupName = "Dsi_Store_Manager", IgnoreApi = false)]
    public class ProductAppService :
      CrudAppService<
          Product, //The Book entity
          ProductDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateProductDto>, //Used to create/update a book
      IProductAppService //implement the IBookAppService
    {

        private readonly IRepository<Product, Guid> _Repository;
        public ProductAppService(IRepository<Product, Guid> repository)
            : base(repository)
        {

        }
    }
}