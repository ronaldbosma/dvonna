using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using dvonna.Shared;

namespace dvonna.Site.Services
{
    public class MessageService : IMessageService
    {
        private const string ReadMessagesKey = "ReadMessages";

        private readonly Lazy<Task<IEnumerable<Message>>> _messages;
        private readonly ILocalStorageService _readMessagesStore;

        public MessageService(IMessageServiceClient client, ILocalStorageService readMessagesStore)
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

            await _readMessagesStore.SetItemAsync(ReadMessagesKey, readMessageIds);
        }

        private async Task<List<int>> GetIdsOfMessagesMarkedAsReadAsync()
        {
            try
            {
                if (await _readMessagesStore.ContainKeyAsync(ReadMessagesKey))
                {
                    return await _readMessagesStore.GetItemAsync<List<int>>(ReadMessagesKey);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error while loading the ids of messages marked as read: {ex}");
            }

            return new List<int>();
        }
    }
}
