using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dvonna.Shared;
using dvonna.Site.Services;
using Microsoft.AspNetCore.Components;

namespace dvonna.Site.Components
{
    public class MessageAlertsComponent : ComponentBase
    {
        [Inject]
        public IMessageService MessageService { get; set; }

        public IEnumerable<Message> Messages { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await LoadMessagesAsync();
        }

        public async Task MarkMessageAsReadAsync(int id)
        {
            await MessageService.MarkMessageAsRead(id);
            await LoadMessagesAsync();
        }

        private async Task LoadMessagesAsync()
        {
            var messages = await MessageService.GetActiveUnreadMessagesAsync();
            Messages = messages.OrderByDescending(m => m.CreatedOn).OrderByDescending(m => m.Id);
        }
    }
}
