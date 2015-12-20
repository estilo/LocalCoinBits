namespace LocalCoinBits.Model.Response
{
    public class AdData
    {
        public bool visible { get; set; }
        public bool hidden_by_opening_hours { get; set; }
        public string email { get; set; }
        public string location_string { get; set; }
        public string countrycode { get; set; }
        public string city { get; set; }
        public string trade_type { get; set; }
        public string online_provider { get; set; }
        public string first_time_limit_btc { get; set; }
        public string volume_coefficient_btc { get; set; }
        public string age_days_coefficient_limit { get; set; }
        public bool sms_verification_required { get; set; }
        public string reference_type { get; set; }
        public string currency { get; set; }
        public string account_info { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string min_amount { get; set; }
        public string max_amount { get; set; }
        public string ad_id { get; set; }
        public string temp_price_usd { get; set; }
        public Profile profile { get; set; }
        public int require_feedback_score { get; set; }
        public object require_trade_volume { get; set; }
        public int payment_window_minutes { get; set; }
        public string bank_name { get; set; }
        public bool track_max_amount { get; set; }
        public string atm_model { get; set; }
    }
}