namespace Lib.Events
{
    public sealed record ScrapPageEvent(int Page)
    {        
        public string Url { get; } = $"https://world.openfoodfacts.org/{Page}";
    }
}
