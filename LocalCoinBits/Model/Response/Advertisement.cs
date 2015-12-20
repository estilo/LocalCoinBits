namespace LocalCoinBits.Model.Response
{
    public class Advertisement
    {
        public int id { get; set; }
        public string trade_type { get; set; }
        public Advertiser advertiser { get; set; }
    }
}