using Model;

namespace Service
{
    public interface IPrizeRedemptionService
    {
        Task<int> PostAsync(PrizeRedemptionRequest request);
    }
}