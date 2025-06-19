using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities;

public abstract class IranAgent
{
	private readonly SensorType[] _weaknesses;
	protected readonly Sensor?[] AttachedSensors;

	protected IranAgent(SensorType[] weaknesses)
	{
		_weaknesses = weaknesses;
		AttachedSensors = new Sensor?[weaknesses.Length];
		IsExposed = false;
	}
	public abstract AgentRank Rank { get; }
	public bool IsExposed { get; private set; }
	protected abstract InvestigationAggregateResult Investigate();

	protected List<SensorActiveResult> CollectSensorResults()
	{
		var results = new List<SensorActiveResult>();
		for (var i = 0; i < AttachedSensors.Length; i++)
		{
			var sensor = AttachedSensors[i];
			if (sensor == null)
			{
				continue;
			}
			var result = sensor.Activate();
			result.SlotIndex = i;
			results.Add(result);
		}
		return results;
	}
	protected InvestigationAggregateResult AnalyzeSensorResults(List<SensorActiveResult> toAnalyze)
	{
		var brokenCount = 0;
		var copyWeaknesses = _weaknesses.ToList();
		foreach (var result in toAnalyze)
		{
			if (result.WasBroken)
			{
				brokenCount++;
			}
			else
			{
				copyWeaknesses.Remove(result.Type);
			}
		}
		IsExposed = copyWeaknesses.Count == 0;
		return new InvestigationAggregateResult
		{
			AgentRank = Rank,
			CorrectMatches = _weaknesses.Length - copyWeaknesses.Count,
			TotalWeaknesses = _weaknesses.Length,
			InternalSensorResults = toAnalyze,
			BrokenCount = brokenCount
		};
	}

	public virtual InvestigationAggregateResult AttachSensor(Sensor sensor, int location)
	{
		if (location < 0 || location >= AttachedSensors.Length)
		{
			throw new ArgumentException("Invalid Sensor location");
		}
		AttachedSensors[location] = sensor;
		return Investigate();
	}
}