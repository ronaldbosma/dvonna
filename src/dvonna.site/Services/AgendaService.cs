﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dvonna.Shared;

namespace dvonna.site.Services
{
    public class AgendaService : IAgendaService
    {
        public Task<Agenda> GetAgendaAsync()
        {
            return Task.FromResult(new Agenda
            {
                PlayDates = new List<PlayDate>
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
                }
            });
        }
    }
}
