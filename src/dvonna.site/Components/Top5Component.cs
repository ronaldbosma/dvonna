using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;
using dvonna.Site.Services;
using Microsoft.AspNetCore.Components;

namespace dvonna.Site.Components
{
    public class Top5Component : ComponentBase
    {
        [Inject]
        public IScoreService ScoreService { get; set; }

        public IEnumerable<PlayerScore> Top5Players { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Top5Players = await ScoreService.GetTop5Async();
        }
    }
}
