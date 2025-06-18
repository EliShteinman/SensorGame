using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.IranAgents;

public class SeniorCommanderAgent : IranAgent
{
	private readonly Random Random = new();
	private int CounterOfInvestigations = 0;
	private void TryRemoveRandomSensors(int count, List<SensorActiveResult> result)
	{
		foreach (var sensorActiveResult in result)
		{
			if (sensorActiveResult.Type == SensorType.Magnetic)
			{
				return;
			}
		}
		for (var i = 0; i < count; i++)
		{
			var removed = Random.Next(0, AttachedSensors.Length);
			AttachedSensors[removed] = null;
			SensorActiveResult toDelete = null;
			foreach (var sensorActiveResult in result)
			{
				if (sensorActiveResult.SlotIndex == removed)
				{
					toDelete = sensorActiveResult;
					break;
				}
			}
			if (toDelete != null)
			{
				result.Remove(toDelete);
			}
		}
	}
	public SeniorCommanderAgent()
			: base(WeaknessesFactory.CreateRandomWeakness(6))
	{
	}
	public override AgentRank Rank => AgentRank.SeniorCommander;

	protected override InvestigationAggregateResult Investigate()
	{
		var result = CollectSensorResults();
		CounterOfInvestigations++;
		if (CounterOfInvestigations % 3 == 0)
		{
			TryRemoveRandomSensors(2, result);
		}
		return AnalyzeSensorResults(result);
	}
}