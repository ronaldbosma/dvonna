using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.ProtectedBrowserStorage;

namespace dvonna.Site.Services
{
    public class UserPreferences : IUserPreferences
    {
        private const string PreferredPlayerIdKey = "PreferredPlayerId";

        // ProtectedLocalStorage can be used to store data across browser sessions
        private readonly ProtectedLocalStorage _preferenceStore;
        private readonly IPlayerService _playerService;

        public UserPreferences(ProtectedLocalStorage preferenceStore, IPlayerService playerService)
        {
            _preferenceStore = preferenceStore ?? throw new ArgumentNullException(nameof(preferenceStore));
            _playerService = playerService ?? throw new ArgumentNullException(nameof(playerService));
        }

        public async Task<int?> GetSavedPlayerIdAsync()
        {
            var savedPlayerId = await _preferenceStore.GetAsync<int?>(PreferredPlayerIdKey);

            if (savedPlayerId.HasValue)
            {
                var player = await _playerService.GetPlayerDetailsAsync(savedPlayerId.Value);
                return player?.Id;
            }
            else
            {
                return null;    
            }
        }

        public async Task SavePlayerIdAsync(int playerId)
        {
            await _preferenceStore.SetAsync(PreferredPlayerIdKey, playerId);
        }

        public async Task RemoveSavedPlayerIdAsync()
        {
            await _preferenceStore.DeleteAsync(PreferredPlayerIdKey);
        }
    }
}
