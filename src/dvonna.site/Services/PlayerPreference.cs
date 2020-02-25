using System;
using System.Threading.Tasks;

namespace dvonna.Site.Services
{
    public class PlayerPreference : IPlayerPreference
    {
        private int? _savedPlayerId = 17;
        private readonly IPlayerService _playerService;

        public PlayerPreference(IPlayerService playerService)
        {
            _playerService = playerService ?? throw new ArgumentNullException(nameof(playerService));
        }

        public async Task<int?> GetSavedPlayerIdAsync()
        {
            var players = await _playerService.GetPlayersAsync();
            var savedPlayerIsExistingPlayer = _savedPlayerId.HasValue && players.ContainsKey(_savedPlayerId.Value);

            return savedPlayerIsExistingPlayer ? _savedPlayerId : null;
        }

        public Task SavePlayerIdAsync(int playerId)
        {
            _savedPlayerId = playerId;
            return Task.CompletedTask;
        }
    }
}
