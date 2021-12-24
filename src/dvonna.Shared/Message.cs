using System;

namespace dvonna.Shared
{
    public class Message
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ShowUntilDate { get; set; }
    }
}
