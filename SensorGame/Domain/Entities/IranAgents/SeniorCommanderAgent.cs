using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.IranAgents;

public class SeniorCommanderAgent : IranAgent
{
	private readonly Random _random = new();
	private int _counterOfInvestigations;
	public SeniorCommanderAgent()
			: base(WeaknessesFactory.CreateRandomWeakness(6))
	{
	}
	public override AgentRank Rank => AgentRank.SeniorCommander;
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
			var removed = _random.Next(0, AttachedSensors.Length);
			AttachedSensors[removed] = null;
			SensorActiveResult? toDelete = null;
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

	protected override InvestigationAggregateResult Investigate()
	{
		var result = CollectSensorResults();
		_counterOfInvestigations++;
		if (_counterOfInvestigations % 3 == 0)
		{
			TryRemoveRandomSensors(2, result);
		}
		return AnalyzeSensorResults(result);
	}
}