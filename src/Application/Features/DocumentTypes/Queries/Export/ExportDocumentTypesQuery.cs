﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SecureDoc.Application.Extensions;
using SecureDoc.Application.Interfaces.Repositories;
using SecureDoc.Application.Interfaces.Services;
using SecureDoc.Application.Specifications.Misc;
using SecureDoc.Domain.Entities.Misc;
using SecureDoc.Shared.Wrapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace SecureDoc.Application.Features.DocumentTypes.Queries.Export
{
    public class ExportDocumentTypesQuery : IRequest<Result<string>>
    {
        public string SearchString { get; set; }

        public ExportDocumentTypesQuery(string searchString = "")
        {
            SearchString = searchString;
        }
    }

    internal class ExportDocumentTypesQueryHandler : IRequestHandler<ExportDocumentTypesQuery, Result<string>>
    {
        private readonly IExcelService _excelService;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IStringLocalizer<ExportDocumentTypesQueryHandler> _localizer;

        public ExportDocumentTypesQueryHandler(IExcelService excelService
            , IUnitOfWork<int> unitOfWork
            , IStringLocalizer<ExportDocumentTypesQueryHandler> localizer)
        {
            _excelService = excelService;
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        public async Task<Result<string>> Handle(ExportDocumentTypesQuery request, CancellationToken cancellationToken)
        {
            var documentTypeFilterSpec = new DocumentTypeFilterSpecification(request.SearchString);
            var documentTypes = await _unitOfWork.Repository<DocumentType>().Entities
                .Specify(documentTypeFilterSpec)
                .ToListAsync(cancellationToken);
            var data = await _excelService.ExportAsync(documentTypes, mappers: new Dictionary<string, Func<DocumentType, object>>
            {
                { _localizer["Id"], item => item.Id },
                { _localizer["Name"], item => item.Name },
                { _localizer["Description"], item => item.Description }
            }, sheetName: _localizer["Document Types"]);

            return await Result<string>.SuccessAsync(data: data);
        }
    }
}