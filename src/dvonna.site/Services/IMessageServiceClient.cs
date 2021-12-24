using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;
using Refit;

namespace dvonna.Site.Services
{
    public interface IMessageServiceClient
    {
        [Get("/messages.json")]
        Task<IEnumerable<Message>> GetMessagesAsync();
    }
}
