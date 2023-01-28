using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using dvonna.Shared;

namespace dvonna.Site.Services
{
    public class UserPreferences : IUserPreferences
    {
        private const string PreferredPlayerIdKey = "PreferredPlayerId";

        // ProtectedLocalStorage can be used to store data across browser sessions
        private readonly ILocalStorageService _preferenceStore;
        private readonly IPlayerService _playerService;

        public UserPreferences(ILocalStorageService preferenceStore, IPlayerService playerService)
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
            try
            {
                if (await _preferenceStore.ContainKeyAsync(PreferredPlayerIdKey))
                {
                    var savedPlayerId = await _preferenceStore.GetItemAsync<int?>(PreferredPlayerIdKey);

                    if (savedPlayerId.HasValue)
                    {
                        return await _playerService.GetPlayerDetailsAsync(savedPlayerId.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error while loading the id of the saved player: {ex}");
            }

            return null;
        }

        public async Task SavePlayerIdAsync(int playerId)
        {
            await _preferenceStore.SetItemAsync(PreferredPlayerIdKey, playerId);
        }

        public async Task RemoveSavedPlayerIdAsync()
        {
            if (await _preferenceStore.ContainKeyAsync(PreferredPlayerIdKey))
            {
                await _preferenceStore.RemoveItemAsync(PreferredPlayerIdKey);
            }
        }
    }
}
