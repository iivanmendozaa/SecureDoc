﻿using SecureDoc.Domain.Contracts;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SecureDoc.Application.Interfaces.Chat;
using SecureDoc.Application.Models.Chat;

namespace SecureDoc.Infrastructure.Models.Identity
{
    public class SecureDocUser : IdentityUser<string>, IChatUser, IAuditableEntity<string>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string CreatedBy { get; set; }

        [Column(TypeName = "text")]
        public string ProfilePictureDataUrl { get; set; }

        public DateTime CreatedOn { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
        public bool IsActive { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public virtual ICollection<ChatHistory<SecureDocUser>> ChatHistoryFromUsers { get; set; }
        public virtual ICollection<ChatHistory<SecureDocUser>> ChatHistoryToUsers { get; set; }

        public SecureDocUser()
        {
            ChatHistoryFromUsers = new HashSet<ChatHistory<SecureDocUser>>();
            ChatHistoryToUsers = new HashSet<ChatHistory<SecureDocUser>>();
        }
    }
}