using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;
using Refit;

namespace dvonna.Site.Services
{
    public interface IPlayedGamesService
    {
        [Get("/played-games-images.json")]
        Task<IEnumerable<PlayedGamesImage>> GetPlayedGamesImagesAsync();
    }
}
