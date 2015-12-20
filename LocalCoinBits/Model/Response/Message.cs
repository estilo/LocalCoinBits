namespace LocalCoinBits.Model.Response
{
    public class Message
    {
        public string msg { get; set; }
        public Sender sender { get; set; }
        public string created_at { get; set; }
        public bool is_admin { get; set; }
        public string attachment_name { get; set; }
        public string attachment_type { get; set; }
        public string attachment_url { get; set; }
    }
}