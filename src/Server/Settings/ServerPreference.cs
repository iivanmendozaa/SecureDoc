using System.Linq;
using SecureDoc.Shared.Constants.Localization;
using SecureDoc.Shared.Settings;

namespace SecureDoc.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}