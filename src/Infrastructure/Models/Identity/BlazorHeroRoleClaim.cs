using System;
using SecureDoc.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace SecureDoc.Infrastructure.Models.Identity
{
    public class SecureDocRoleClaim : IdentityRoleClaim<string>, IAuditableEntity<int>
    {
        public string Description { get; set; }
        public string Group { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public virtual SecureDocRole Role { get; set; }

        public SecureDocRoleClaim() : base()
        {
        }

        public SecureDocRoleClaim(string roleClaimDescription = null, string roleClaimGroup = null) : base()
        {
            Description = roleClaimDescription;
            Group = roleClaimGroup;
        }
    }
}