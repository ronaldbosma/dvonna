using System.Collections.Generic;
using System.Threading.Tasks;

namespace dvonna.Site.Services
{
    public class PlayerService : IPlayerService
    {
        public Task<IDictionary<int, string>> GetPlayersAsync()
        {
            return Task.FromResult<IDictionary<int, string>>(new Dictionary<int, string>
            {
                { 1, "Tom" },
                { 2, "Pete" },
                { 3, "Hendrik" },
                { 4, "Lara" },
                { 5, "Jason" },
                { 6, "Tamara" },
                { 7, "Sara" },
                { 8, "Anton" },
                { 10, "Jerry" },
                { 12, "Justing" },
                { 13, "Johnny H." },
                { 14, "Johhny Q." },
                { 15, "Harold" },
                { 16, "Sean" },
                { 17, "Rosalind" },
                { 20, "Rose" },
                { 23, "Edna" },
                { 21, "Carlos" }
            });
        }
    }
}
