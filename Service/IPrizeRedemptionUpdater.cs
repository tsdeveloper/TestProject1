using Model;

namespace Service
{
    public interface IPrizeRedemptionUpdater
    {
        Task<int> PostAsync(PrizeRedemptionEntity request);
    }
}