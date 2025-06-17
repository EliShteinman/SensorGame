using SensorGame.Domain.Entities.Sensors;
using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.IranAgents;

public class FootSoldierAgent : IranAgent
{
	public FootSoldierAgent()
			: base(SensorFactory.CreateRandomWeaknessSensors(2))
	{
	}
	public override AgentRank Rank => AgentRank.FootSoldier;

	protected override InvestigationAggregateResult Investigate()
	{
		var results = new List<SensorExecutionResult>();
		foreach (var sensor in AttachedSensors)
		{
			results.Add(sensor.Activate(this));
		}
		throw new NotImplementedException();
	}
}