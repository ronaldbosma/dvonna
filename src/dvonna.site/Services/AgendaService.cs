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
                new PlayDate { Date = new DateTime(2019, 9, 13) },
                new PlayDate { Date = new DateTime(2019, 10, 11) },
                new PlayDate { Date = new DateTime(2019, 11, 8) },
                new PlayDate { Date = new DateTime(2019, 12, 13) },
                new PlayDate { Date = new DateTime(2020, 1, 10) },
                new PlayDate { Date = new DateTime(2020, 2, 14) },
                new PlayDate { Date = new DateTime(2020, 3, 13) },
                new PlayDate { Date = new DateTime(2020, 4, 10) },
                new PlayDate { Date = new DateTime(2020, 5, 8), Comments = "BBQ, aanvang 6 uur" },
            });
        }
    }
}
