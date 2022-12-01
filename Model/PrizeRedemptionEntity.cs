namespace Model
{
    public class PrizeRedemptionEntity
    {
        public long RedemptionId { get; set; }

        public string? LotteryName { get; set; }

        public long? LotteryId { get; set; }

        public long? UserCode { get; set; }

        public DateTime Draw { get; set; }

        public DateTime CreatedTime { get; set; }

        public string? Game { get; set; }

        public long? ContestNumber { get; set; }

        public long? ContestNumberRef { get; set; }

        public string? GroupName { get; set; }

        public long? GroupCode { get; set; }

        public int AwardWinningGames { get; set; }

        public long? QuotaQuantity { get; set; }

        public decimal Jackpot { get; set; }

        public decimal Price { get; set; }

        public string? CPF { get; set; }

        public string? Email { get; set; }

        public string? Status { get; set; } = "Teste";

        public string? SiteOrigin { get; set; }
        public string? BankNumber { get; set; }
        public string? AgencyNumber { get; set; }
        public string? CurrentAccount { get; set; }
        public string? CurrentAccountDocument { get; set; }
        public string? BankName { get; set; }
        public string? HonorName { get; set; }
        public string? AccountHolder { get; set; }
        public string? AccountType { get; set; }
        public string? AgencyDigit { get; set; }
        public string RedemptionType { get; set; }
        public long AccountNumber { get; set; }
        public decimal? Fee { get; set; }
        public string? IP { get; set; }
        public long? SiteCode { get; set; }
        public bool? IsAdministrator { get; set; }
        public decimal JackpotLimit { get; set; }
        public DateTime? RequestTime { get; private set; }

        public static PrizeRedemptionEntity From(PrizeRedemptionRequest prizeRedemptionRequest)
        {
            return new PrizeRedemptionEntity
            {
                LotteryName = prizeRedemptionRequest.LotteryName,
                LotteryId = prizeRedemptionRequest.LotteryId,
                UserCode = prizeRedemptionRequest.UserCode,
                Draw = prizeRedemptionRequest.Draw,
                ContestNumber = prizeRedemptionRequest.ContestNumber,
                CreatedTime = DateTime.Now,
                Game = prizeRedemptionRequest.Game?.ToUpper(),
                Jackpot = prizeRedemptionRequest.Jackpot,
                Price = prizeRedemptionRequest.Price,
                QuotaQuantity = prizeRedemptionRequest.QuotaQuantity,
                GroupName = prizeRedemptionRequest.GroupName,
                GroupCode = prizeRedemptionRequest.GroupCode,
                AwardWinningGames = prizeRedemptionRequest.AwardWinningGames,
                CPF = prizeRedemptionRequest.Document,
                Email = prizeRedemptionRequest.Email,
                ContestNumberRef = prizeRedemptionRequest.ContestNumberRef,
                SiteOrigin = prizeRedemptionRequest.SiteOrigin?.ToUpper(),
                JackpotLimit = prizeRedemptionRequest.JackpotLimit,
                RedemptionType = "Te"
            };
        }

    }
}