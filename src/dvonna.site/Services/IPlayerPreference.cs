using System.Threading.Tasks;

namespace dvonna.Site.Services
{
    /// <summary>
    /// Can be used to retrieve and store a preferred player.
    /// </summary>
    public interface IPlayerPreference
    {
        /// <summary>
        /// Gets the saved player id if found, else null.
        /// </summary>
        Task<int?> GetSavedPlayerIdAsync();

        /// <summary>
        /// Saved <paramref name="playerId"/> as the preferred player.
        /// </summary>
        Task SavePlayerIdAsync(int playerId);
    }
}
