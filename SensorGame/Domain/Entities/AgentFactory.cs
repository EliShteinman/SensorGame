using SensorGame.Domain.Entities.IranAgents;
using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities;

public static class AgentFactory
{
	public static IranAgent CreateAgentByType(AgentRank rank)
	{
		switch (rank)
		{
			case AgentRank.FootSoldier:
				return new FootSoldierAgent();
			case AgentRank.SquadLeader:
				return new SquadLeaderAgent();
			case AgentRank.SeniorCommander:
				return new SeniorCommanderAgent();
			case AgentRank.OrganizationLeader:
				return new OrganizationLeaderAgent();
			default:
				throw new ArgumentException("Invalid agent rank");
		}
	}
}