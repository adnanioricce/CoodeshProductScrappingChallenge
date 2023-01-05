using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public enum ProductScrapStatus
    {
        ToBeImported = 0,
        Imported = 1
    }
    public record struct ProductScrapPage
    {
        public int Id { get; private set; }
        public string Url { get; private set; }
        public ProductScrapStatus Status { get; private set; }
        public DateTimeOffset? ScrappedAt { get; private set; }
        public ProductScrapPage(string url)
        {
            Id = 0;
            Url = url;
            Status = ProductScrapStatus.ToBeImported;
            ScrappedAt = null;
        }
        public ProductScrapPage MarkAsImported()
        {
            return this with
            {
                Status = ProductScrapStatus.Imported,
                ScrappedAt = DateTimeOffset.Now
            };            
        }
    }
}
