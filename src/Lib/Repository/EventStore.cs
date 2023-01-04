using Lib.Events;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repository
{
    public sealed class EventStore
    {
        private readonly string _connectionString = "mongodb://localhost:27017";
        private readonly string _dbName = "EventStore";
        private readonly string _scrapEventCollectionName = "PageToScrapEvents";
        private readonly IMongoCollection<ScrapPageEvent> _scrapPageEvents;
        private readonly IMongoCollection<PageScrappedEvent> _pageScrappedEvents;
        public EventStore()
        {
            var mongoClient = new MongoClient(_connectionString);

            var mongoDatabase = mongoClient.GetDatabase(_dbName);

            _scrapPageEvents = mongoDatabase.GetCollection<ScrapPageEvent>(_scrapEventCollectionName);
            _pageScrappedEvents = mongoDatabase.GetCollection<PageScrappedEvent>("PageScrappedEvents");
        }
        public async Task<List<ScrapPageEvent>> GetEventsAsync() =>
            await _scrapPageEvents.Find(_ => true).ToListAsync();
        
        public async Task<ScrapPageEvent?> GetAsync(string url) =>
            await _scrapPageEvents.Find(x => x.Url == url).FirstOrDefaultAsync();

        public async Task BulkCreateAsync(IEnumerable<ScrapPageEvent> events)
        {
            await _scrapPageEvents.InsertManyAsync(events);
        }
    }
}
