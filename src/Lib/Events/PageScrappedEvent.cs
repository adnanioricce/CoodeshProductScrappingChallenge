using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Events
{
    public record struct PageScrappedEvent 
    {
        public long Id { get; }
        public string Url { get; }
        public DateTimeOffset ScrappedAt { get; }
        public PageScrappedEvent(long Id, string Url, DateTimeOffset ScrappedAt)
        {
            this.Id = Id;
            this.Url = Url;
            this.ScrappedAt = ScrappedAt;
        }
    }
}
