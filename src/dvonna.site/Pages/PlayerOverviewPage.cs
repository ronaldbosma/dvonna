using System;
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

        public IDictionary<int, string> Players { get; set; }

        public string SelectedPlayerId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Players = await PlayerService.GetPlayersAsync();
        }
    }
}
