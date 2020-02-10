﻿using System.Collections.Generic;
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

        public IEnumerable<PlayerScore> Score { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Score = await ScoreService.GetScoreAsync();
        }
    }
}
