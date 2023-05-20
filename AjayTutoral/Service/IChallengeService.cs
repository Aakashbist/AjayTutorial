using static AjayTutoral.Model.ChallengeApiResponse;
namespace AjayTutoral.Service
{
    public interface IChallengeService
    {
        Task<List<Root>> GetChallenges();
    }
}
