
using Chatora.Services.RewardsAPI.Message;

namespace Chatora.Services.RewardsAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardsMessage rewardsMessage);
    }
}
