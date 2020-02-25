using System.Collections.Generic;
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

        public IDictionary<int, string> Players { get; set; }

        public string SelectedPlayerId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Players = await PlayerService.GetPlayersAsync();
            SelectedPlayerId = await LoadSelectedPlayerIdAsync();
        }

        private async Task<string> LoadSelectedPlayerIdAsync()
        {
            var savedPlayerId = await PlayerPreference.GetSavedPlayerIdAsync();
            return savedPlayerId?.ToString();
        }
    }
}
