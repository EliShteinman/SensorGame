using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.IranAgents;

public class SquadLeaderAgent : IranAgent
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
	public SquadLeaderAgent()
			: base(WeaknessesFactory.CreateRandomWeakness(4))
	{
	}
	public override AgentRank Rank => AgentRank.SquadLeader;

	protected override InvestigationAggregateResult Investigate()
	{
		var result = CollectSensorResults();
		CounterOfInvestigations++;
		if (CounterOfInvestigations % 3 == 0)
		{
			TryRemoveRandomSensors(1, result);
		}
		return AnalyzeSensorResults(result);
	}
}