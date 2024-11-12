﻿using SecureDoc.Application.Features.Documents.Commands.AddEdit;
using SecureDoc.Application.Features.Documents.Queries.GetAll;
using SecureDoc.Application.Requests.Documents;
using SecureDoc.Shared.Wrapper;
using System.Threading.Tasks;
using SecureDoc.Application.Features.Documents.Queries.GetById;

namespace SecureDoc.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}