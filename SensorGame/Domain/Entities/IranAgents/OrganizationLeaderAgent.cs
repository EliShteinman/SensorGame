using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.IranAgents;

public class OrganizationLeaderAgent : IranAgent
{
	public OrganizationLeaderAgent()
			: base(WeaknessesFactory.CreateRandomWeakness(8))
	{
	}
	public override AgentRank Rank => AgentRank.OrganizationLeader;

	protected override InvestigationAggregateResult Investigate()
	{
		throw new NotImplementedException();
	}
}