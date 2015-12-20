namespace LocalCoinBits.Model.Response
{
    public class AccountDetails
    {
        public string receiver_name { get; set; }
        public string iban { get; set; }
        public string swift_bic { get; set; }
        public string reference { get; set; }
    }
}