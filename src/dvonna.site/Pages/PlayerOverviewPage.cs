using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dvonna.Site.Services;
using Microsoft.AspNetCore.Components;

namespace dvonna.Site.Pages
{
    public class PlayerOverviewPage : ComponentBase
    {
        [Inject]
        public IPlayerService PlayerService { get; set; }

        [Inject]
        public IPlayerPreference PlayerPreference { get; set; }

        public IOrderedEnumerable<KeyValuePair<int, string>> Players { get; set; }

        public string SelectedPlayerId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Players = await GetPlayersOrderedByNameAsync();
            SelectedPlayerId = await LoadSelectedPlayerIdAsync();
        }

        private async Task<IOrderedEnumerable<KeyValuePair<int, string>>> GetPlayersOrderedByNameAsync()
        {
            var players = await PlayerService.GetPlayersAsync();
            return players.OrderBy(p => p.Value);
        }

        private async Task<string> LoadSelectedPlayerIdAsync()
        {
            var savedPlayerId = await PlayerPreference.GetSavedPlayerIdAsync();
            return savedPlayerId?.ToString();
        }

        public async Task SaveSelectedPlayer()
        {
            if (int.TryParse(SelectedPlayerId, out int selectedPlayerId))
            {
                await PlayerPreference.SavePlayerIdAsync(selectedPlayerId);
            }
        }
    }
}
