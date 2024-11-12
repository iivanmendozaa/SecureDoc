using SecureDoc.Application.Interfaces.Services;
using System;

namespace SecureDoc.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}