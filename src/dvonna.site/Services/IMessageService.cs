using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;

namespace dvonna.Site.Services
{
    public interface IMessageService
    {
        Task<IEnumerable<Message>> GetMessagesAsync();

        Task<IEnumerable<Message>> GetActiveUnreadMessagesAsync();

        Task MarkMessageAsRead(int id);
    }
}
