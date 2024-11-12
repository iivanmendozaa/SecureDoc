
using SecureDoc.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace SecureDoc.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}