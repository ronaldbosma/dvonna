using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;
using dvonna.Site.Services;
using Microsoft.AspNetCore.Components;

namespace dvonna.Site.Pages
{
    public class ScoreOverviewPage : ComponentBase
    {
        [Inject]
        public IScoreService ScoreService { get; set; }

        [Inject]
        public IUserPreferences UserPreferences { get; set; }

        public IEnumerable<PlayerScore> Score { get; set; }

        public int? SelectedPlayerId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Score = await ScoreService.GetScoreAsync();
            SelectedPlayerId = await UserPreferences.GetSavedPlayerIdAsync();
        }
    }
}
