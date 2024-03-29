﻿using System.Threading.Tasks;
using dvonna.Shared;
using dvonna.Site.Services;
using Microsoft.AspNetCore.Components;

namespace dvonna.Site.Components
{
    public class PlayerInfoComponent : ComponentBase
    {
        [Inject]
        public IPlayerService PlayerService { get; set; }

        [Inject]
        public IUserPreferences UserPreferences { get; set; }

        public PlayerDetails SelectedPlayer { get; private set; }

        protected async override Task OnInitializedAsync()
        {
            SelectedPlayer = await UserPreferences.GetSavedPlayerDetailsAsync();
        }
    }
}
