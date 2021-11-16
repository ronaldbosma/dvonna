using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;
using Refit;

namespace dvonna.Site.Services
{
    public interface IScoreService
    {
        [Get("/top5.json")]
        Task<IEnumerable<PlayerScore>> GetTop5Async();

        [Get("/score.json")]
        Task<IEnumerable<PlayerScore>> GetScoreAsync();

        [Get("/dartoverview.json")]
        Task<IEnumerable<DartOverviewRow>> GetDartOverviewAsync();
    }
}
