using System;
using System.Threading.Tasks;
using dvonna.Shared;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

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
            var player = await GetSavedPlayerDetailsAsync();
            return player?.Id;
        }

        public async Task<PlayerDetails> GetSavedPlayerDetailsAsync()
        {
            var savedPlayerId = await _preferenceStore.GetAsync<int?>(PreferredPlayerIdKey);

            if (savedPlayerId.Success && savedPlayerId.Value.HasValue)
            {
                return await _playerService.GetPlayerDetailsAsync(savedPlayerId.Value.Value);
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
