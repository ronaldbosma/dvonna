using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;

namespace dvonna.Site.Services
{
    public interface IScoreService
    {
        Task<IEnumerable<PlayerScore>> GetTop5Async();
    }
}
