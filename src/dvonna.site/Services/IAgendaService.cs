using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;
using Refit;

namespace dvonna.Site.Services
{
    public interface IAgendaService
    {
        [Get("/agenda.json")]
        Task<IEnumerable<PlayDate>> GetAgendaAsync();
    }
}
