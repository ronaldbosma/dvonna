using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;

namespace dvonna.Site.Services
{
    public class MessageService : IMessageService
    {
        private readonly Lazy<Task<IEnumerable<Message>>> _messages;

        public MessageService(IMessageServiceClient client)
        {
            _messages = new Lazy<Task<IEnumerable<Message>>>(() => client.GetMessagesAsync());
        }

        public async Task<IEnumerable<Message>> GetMessagesAsync()
        {
            return await _messages.Value;
        }

        public async Task<IEnumerable<Message>> GetActiveUnreadMessagesAsync()
        {
            var messages = await _messages.Value;
            var referenceDate = DateTime.Today;

            var activeMessages = messages.Where(m => m.ShowUntilDate.Date >= referenceDate);

            //TODO: filter unread

            return activeMessages;
        }

        public Task MarkMessageAsRead(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
