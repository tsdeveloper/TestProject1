using Model;

namespace Service
{
    public class PrizeRedemptionService : IPrizeRedemptionService
    {
        private readonly IPrizeRedemptionUpdater prizeRedemptionUpdater;

        public PrizeRedemptionService(IPrizeRedemptionUpdater prizeRedemptionUpdater)
        {
            this.prizeRedemptionUpdater = prizeRedemptionUpdater;
        }
        public async Task<int> PostAsync(PrizeRedemptionRequest request)
        {
            var entity = PrizeRedemptionEntity.From(request);

            return await prizeRedemptionUpdater.PostAsync(entity);
        }
    }
}
