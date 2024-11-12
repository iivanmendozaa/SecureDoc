using SecureDoc.Shared.Settings;
using System.Threading.Tasks;
using SecureDoc.Shared.Wrapper;

namespace SecureDoc.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}