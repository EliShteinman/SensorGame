using SensorGame.Domain.Entities.Sensors;
using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.IranAgents;

public class SeniorCommanderAgent : IranAgent
{
	public SeniorCommanderAgent()
			: base(SensorFactory.CreateRandomWeaknessSensors(6))
	{
	}
	public override AgentRank Rank => AgentRank.SeniorCommander;

	protected override InvestigationAggregateResult Investigate()
	{
		throw new NotImplementedException();
	}
}