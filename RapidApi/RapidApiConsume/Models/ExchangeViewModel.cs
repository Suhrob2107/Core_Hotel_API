namespace RapidApiConsume.Models
{
    public class ExchangeViewModel
    {
        public bool status { get; set; }
        public string message { get; set; }
        public long timestamp { get; set; }
        public ExchangeData data { get; set; }  // ← Burada "data" tanımlı!
    }

    public class ExchangeData
    {
        public List<ExchangeRate> exchange_rates { get; set; }
        public string base_currency { get; set; }
        public string base_currency_date { get; set; }
    }

    public class ExchangeRate
    {
        public string exchange_rate_buy { get; set; }
        public string currency { get; set; }
    }
}
