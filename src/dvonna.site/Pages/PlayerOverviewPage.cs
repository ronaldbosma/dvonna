using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dvonna.Shared;
using dvonna.Site.Services;
using Microsoft.AspNetCore.Components;

namespace dvonna.Site.Pages
{
    public class PlayerOverviewPage : ComponentBase
    {
        [Inject]
        public IPlayerService PlayerService { get; set; }

        [Inject]
        public IUserPreferences UserPreferences { get; set; }

        public IOrderedEnumerable<PlayerDetails> Players { get; set; }

        public string SelectedPlayerId { get; set; }

        public PlayerDetails SelectedPlayer
        {
            get
            {
                return GetSelectedPlayer();
            }
        }

        private PlayerDetails GetSelectedPlayer()
        {
            if (int.TryParse(SelectedPlayerId, out int selectedPlayerId))
            {
                return Players.SingleOrDefault(p => p.Id == selectedPlayerId);
            }

            return null;
        }

        protected override async Task OnInitializedAsync()
        {
            Players = await GetPlayersOrderedByNameAsync();
            SelectedPlayerId = await LoadSelectedPlayerIdAsync();
        }

        private async Task<IOrderedEnumerable<PlayerDetails>> GetPlayersOrderedByNameAsync()
        {
            var players = await PlayerService.GetPlayersAsync();
            return players.OrderBy(p => p.Name);
        }

        private async Task<string> LoadSelectedPlayerIdAsync()
        {
            var savedPlayerId = await UserPreferences.GetSavedPlayerIdAsync();
            return savedPlayerId?.ToString();
        }

        public async Task SaveSelectedPlayer()
        {
            if (int.TryParse(SelectedPlayerId, out int selectedPlayerId))
            {
                await UserPreferences.SavePlayerIdAsync(selectedPlayerId);
            }
            else
            {
                await UserPreferences.RemoveSavedPlayerIdAsync();
            }
        }
    }
}
