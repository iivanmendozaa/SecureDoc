﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SecureDoc.Application.Features.ExtendedAttributes.Commands.AddEdit;
using SecureDoc.Application.Features.ExtendedAttributes.Queries.Export;
using SecureDoc.Application.Features.ExtendedAttributes.Queries.GetAll;
using SecureDoc.Application.Features.ExtendedAttributes.Queries.GetAllByEntityId;
using SecureDoc.Domain.Contracts;
using SecureDoc.Shared.Wrapper;

namespace SecureDoc.Client.Infrastructure.Managers.ExtendedAttribute
{
    public interface IExtendedAttributeManager<TId, TEntityId, TEntity, TExtendedAttribute>
        where TEntity : AuditableEntity<TEntityId>, IEntityWithExtendedAttributes<TExtendedAttribute>, IEntity<TEntityId>
        where TExtendedAttribute : AuditableEntityExtendedAttribute<TId, TEntityId, TEntity>, IEntity<TId>
        where TId : IEquatable<TId>
    {
        Task<IResult<List<GetAllExtendedAttributesResponse<TId, TEntityId>>>> GetAllAsync();

        Task<IResult<List<GetAllExtendedAttributesByEntityIdResponse<TId, TEntityId>>>> GetAllByEntityIdAsync(TEntityId entityId);

        Task<IResult<TId>> SaveAsync(AddEditExtendedAttributeCommand<TId, TEntityId, TEntity, TExtendedAttribute> request);

        Task<IResult<TId>> DeleteAsync(TId id);

        Task<IResult<string>> ExportToExcelAsync(ExportExtendedAttributesQuery<TId, TEntityId, TEntity, TExtendedAttribute> request);
    }
}