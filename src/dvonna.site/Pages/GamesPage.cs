using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;
using dvonna.Site.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;

namespace dvonna.Site.Pages
{
    public class GamesPage : ComponentBase
    {
        [Inject]
        public IPlayedGamesService PlayedGamesService { get; set; }

        [Inject]
        public IOptions<DvOnnaConfig> Config { get; set; }

        public IEnumerable<PlayedGamesImage> PlayedGamesImages { get; set; }

        protected override async Task OnInitializedAsync()
        {
            PlayedGamesImages = await PlayedGamesService.GetPlayedGamesImagesAsync();
        }

        protected string GetFullImageUri(PlayedGamesImage image)
        {
            return $"{Config.Value.DataEndpoint}/played-games/{image.PlayedGamesImageFileName}";
        }
    }
}
