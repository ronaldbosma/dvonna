using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dvonna.Shared;
using dvonna.Site.Services;
using Microsoft.AspNetCore.Components;

namespace dvonna.Site.Components
{
    public class AgendaComponent : ComponentBase
    {
        [Inject]
        public IAgendaService AgendaService { get; set; }

        public IEnumerable<PlayDate> PlayDates { get; set; }

        protected override async Task OnInitializedAsync()
        {
            PlayDates = await AgendaService.GetAgendaAsync();
        }
    }
}
