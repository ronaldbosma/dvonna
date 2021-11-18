using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;
using dvonna.Site.Services;
using Microsoft.AspNetCore.Components;

namespace dvonna.Site.Pages
{
    public class GamesPage : ComponentBase
    {
        [Inject]
        public IPlayedGamesService PlayedGamesService { get; set; }

        public IEnumerable<PlayedGamesImage> PlayedGamesImages { get; set; }

        protected override async Task OnInitializedAsync()
        {
            PlayedGamesImages = await PlayedGamesService.GetPlayedGamesImagesAsync();
        }
    }
}
