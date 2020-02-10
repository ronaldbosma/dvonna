﻿using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;
using dvonna.Site.Services;
using Microsoft.AspNetCore.Components;

namespace dvonna.Site.Pages
{
    public class DartsOverviewPage : ComponentBase
    {
        [Inject]
        public IScoreService ScoreService { get; set; }

        public IEnumerable<DartOverviewRow> DartOverviewScore { get; set; }

        protected async override Task OnInitializedAsync()
        {
            DartOverviewScore = await ScoreService.GetDartOverviewAsync();
        }
    }
}
