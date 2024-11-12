using System.Text.Json;
using SecureDoc.Application.Interfaces.Serialization.Options;

namespace SecureDoc.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}