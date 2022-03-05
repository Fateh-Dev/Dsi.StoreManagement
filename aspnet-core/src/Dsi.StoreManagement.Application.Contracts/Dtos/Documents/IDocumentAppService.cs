using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dsi.StoreManagement.Documents
{
    public interface IDocumentAppService :
      ICrudAppService< //Defines CRUD methods
          DocumentDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateDocumentDto> //Used to create/update a book
    {

    }
}