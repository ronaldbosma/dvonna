﻿using System;
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
            var players = await _playerService.GetPlayersAsync();

            var savedPlayerIsExistingPlayer = savedPlayerId.HasValue && players.ContainsKey(savedPlayerId.Value);

            return savedPlayerIsExistingPlayer ? savedPlayerId : null;
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
