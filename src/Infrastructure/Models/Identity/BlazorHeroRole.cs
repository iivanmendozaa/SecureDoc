using System;
using System.Collections.Generic;
using SecureDoc.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace SecureDoc.Infrastructure.Models.Identity
{
    public class SecureDocRole : IdentityRole, IAuditableEntity<string>
    {
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public virtual ICollection<SecureDocRoleClaim> RoleClaims { get; set; }

        public SecureDocRole() : base()
        {
            RoleClaims = new HashSet<SecureDocRoleClaim>();
        }

        public SecureDocRole(string roleName, string roleDescription = null) : base(roleName)
        {
            RoleClaims = new HashSet<SecureDocRoleClaim>();
            Description = roleDescription;
        }
    }
}