using System;

namespace LocalCoinBits.Model.Response
{
    public class AccountInfo
    {
        public string username { get; set; }
        public DateTime created_at { get; set; }
        public int trading_partners_count { get; set; }
        public int feedbacks_unconfirmed_count { get; set; }
        public string trade_volume_text { get; set; }
        public bool has_common_trades { get; set; }
        public bool has_feedback { get; set; }
        public string confirmed_trade_count_text { get; set; }
        public int blocked_count { get; set; }
        public int feedback_score { get; set; }
        public int feedback_count { get; set; }
        public string url { get; set; }
        public int trusted_count { get; set; }
        public DateTime? identity_verified_at { get; set; }
    }
}