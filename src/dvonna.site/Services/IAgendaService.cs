using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;

namespace dvonna.Site.Services
{
    public interface IAgendaService
    {
        Task<IEnumerable<PlayDate>> GetAgendaAsync();
    }
}
