using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dvonna.Shared;

namespace dvonna.site.Services
{
    public interface IAgendaService
    {
        Task<Agenda> GetAgendaAsync();
    }
}
