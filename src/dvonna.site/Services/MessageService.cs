using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;
using Microsoft.AspNetCore.ProtectedBrowserStorage;

namespace dvonna.Site.Services
{
    public class MessageService : IMessageService
    {
        private const string ReadMessagesKey = "ReadMessages";

        private readonly Lazy<Task<IEnumerable<Message>>> _messages;
        // ProtectedLocalStorage can be used to store data across browser sessions
        private readonly ProtectedLocalStorage _readMessagesStore;

        public MessageService(IMessageServiceClient client, ProtectedLocalStorage readMessagesStore)
        {
            _messages = new Lazy<Task<IEnumerable<Message>>>(() => client.GetMessagesAsync());
            _readMessagesStore = readMessagesStore;
        }

        public async Task<IEnumerable<Message>> GetMessagesAsync()
        {
            return await _messages.Value;
        }

        public async Task<IEnumerable<Message>> GetActiveUnreadMessagesAsync()
        {
            var messages = await _messages.Value;
            var readMessageIds = await GetIdsOfMessagesMarkedAsReadAsync();

            return messages.Where(m => m.ShowUntilDate.Date >= DateTime.Today && !readMessageIds.Contains(m.Id));
        }

        public async Task MarkMessageAsRead(int id)
        {
            var readMessageIds = await GetIdsOfMessagesMarkedAsReadAsync();
            readMessageIds.Add(id);

            await _readMessagesStore.SetAsync(ReadMessagesKey, readMessageIds);
        }

        private async Task<List<int>> GetIdsOfMessagesMarkedAsReadAsync()
        {
            return await _readMessagesStore.GetAsync<List<int>>(ReadMessagesKey) ?? new List<int>();
        }
    }
}
