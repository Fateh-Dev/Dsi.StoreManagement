using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dsi.StoreManagement.Documents
{
    public class DocumentAppService :
         CrudAppService<
             Document, //The Book entity
             DocumentDto, //Used to show books
             Guid, //Primary key of the book entity
             PagedAndSortedResultRequestDto, //Used for paging/sorting
             CreateUpdateDocumentDto>, //Used to create/update a book
         IDocumentAppService //implement the IBookAppService
    {
        public DocumentAppService(IRepository<Document, Guid> repository)
            : base(repository)
        {

        }
    }
}