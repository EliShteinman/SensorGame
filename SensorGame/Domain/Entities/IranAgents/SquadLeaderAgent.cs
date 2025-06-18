using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.IranAgents;

public class SquadLeaderAgent : IranAgent
{
	public SquadLeaderAgent()
			: base(WeaknessesFactory.CreateRandomWeakness(4))
	{
	}
	public override AgentRank Rank => AgentRank.SquadLeader;

	protected override InvestigationAggregateResult Investigate()
	{
		throw new NotImplementedException();
	}
}