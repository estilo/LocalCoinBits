namespace LocalCoinBits.Model.Response
{
    public abstract class AUser
    {
        public string username { get; set; }
        public string trade_count { get; set; }
        public string feedback_score { get; set; }
        public string name { get; set; }
        public string last_seen_on { get; set; }
    }
}