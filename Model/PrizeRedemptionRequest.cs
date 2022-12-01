using Newtonsoft.Json;

namespace Model
{
    public class PrizeRedemptionRequest
    {
        [JsonProperty("lottery_name")]
        public string LotteryName { get; set; }

        [JsonProperty("lottery_id")]
        public long LotteryId { get; set; }

        [JsonProperty("user_code")]
        public long UserCode { get; set; }

        [JsonProperty("draw")]
        public DateTime Draw { get; set; }

        [JsonProperty("game")]
        public string Game { get; set; }

        [JsonProperty("contest_number")]
        public long ContestNumber { get; set; }

        [JsonProperty("quota_quantity")]
        public long QuotaQuantity { get; set; }

        [JsonProperty("jackpot")]
        public decimal Jackpot { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("group_name")]
        public string GroupName { get; set; }

        [JsonProperty("group_code")]
        public long GroupCode { get; set; }

        [JsonProperty("award_winning_games")]
        public int AwardWinningGames { get; set; }

        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("contest_number_ref")]
        public long ContestNumberRef { get; set; }

        [JsonProperty("site_origin")]
        public string SiteOrigin { get; set; } = "VTEX";

        [JsonProperty("jackpot_limit")]
        public decimal JackpotLimit { get; set; }
    }
}