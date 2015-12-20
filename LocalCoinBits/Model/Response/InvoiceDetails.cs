namespace LocalCoinBits.Model.Response
{
    public class InvoiceDetails
    {
        public string description { get; set; }
        public string created { get; set; }
        public string url { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }
        public string state { get; set; }
        public string id { get; set; }
        public object btc_amount { get; set; }
        public bool deleting_allowed { get; set; }
    }
}