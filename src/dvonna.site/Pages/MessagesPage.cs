using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dvonna.Shared;
using dvonna.Site.Services;
using Microsoft.AspNetCore.Components;

namespace dvonna.Site.Pages
{
    public class MessagesPage : ComponentBase
    {
        [Inject]
        public IMessageService MessageService { get; set; }

        public IEnumerable<Message> Messages { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var messages = await MessageService.GetMessagesAsync();
            Messages = messages.OrderByDescending(m => m.CreatedOn).OrderByDescending(m => m.Id);
        }
    }
}
