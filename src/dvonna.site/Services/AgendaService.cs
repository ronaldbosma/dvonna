using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;

namespace dvonna.Site.Services
{
    public class AgendaService : IAgendaService
    {
        public Task<IEnumerable<PlayDate>> GetAgendaAsync()
        {
            return Task.FromResult<IEnumerable<PlayDate>>(new List<PlayDate>
            {
                new PlayDate { Date = new DateTime(2021, 9, 13) },
                new PlayDate { Date = new DateTime(2021, 10, 11) },
                new PlayDate { Date = new DateTime(2021, 11, 8) },
                new PlayDate { Date = new DateTime(2021, 12, 13) },
                new PlayDate { Date = new DateTime(2022, 1, 10) },
                new PlayDate { Date = new DateTime(2022, 2, 14) },
                new PlayDate { Date = new DateTime(2022, 3, 13) },
                new PlayDate { Date = new DateTime(2022, 4, 10) },
                new PlayDate { Date = new DateTime(2022, 5, 8), Comments = "BBQ, aanvang 6 uur" },
            });
        }
    }
}
