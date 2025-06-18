using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.IranAgents;

public class FootSoldierAgent : IranAgent
{
	public FootSoldierAgent()
			: base(WeaknessesFactory.CreateRandomWeakness(2))
	{
	}
	public override AgentRank Rank => AgentRank.FootSoldier;
	protected override InvestigationAggregateResult Investigate()
	{
		var result = CollectSensorResults();
		return AnalyzeSensorResults(result);
	}
}