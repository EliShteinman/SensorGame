using SensorGame.Domain.Entities.Sensors;
using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities;

public abstract class IranAgent
{
	protected readonly Sensor[] AttachedSensors;
	protected readonly SensorType[] Weaknesses;

	protected IranAgent(SensorType[] weaknesses)
	{
		Weaknesses = weaknesses;
		AttachedSensors = new Sensor[weaknesses.Length];
		IsExposed = false;
	}
	public abstract AgentRank Rank { get; }
	public bool IsExposed { get; protected set; }
	protected abstract InvestigationAggregateResult Investigate();
	
	protected List<SensorActiveResult> CollectSensorResults()
	{
		var results = new List<SensorActiveResult>();
		for (var i = 0; i < AttachedSensors.Length; i++)
		{
			if (AttachedSensors[i] == null)
			{
				continue;
			}
			var result = AttachedSensors[i].Activate();
			result.SlotIndex = i;
			results.Add(result);
		}
		return results;
	}
	protected InvestigationAggregateResult AnalyzeSensorResults(List<SensorActiveResult> toAnalyze)
	{
		var brokenCount = 0;
		var copyWeaknesses = Weaknesses.ToList();
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
		IsExposed = (copyWeaknesses.Count == 0);
		return new InvestigationAggregateResult
		{
			AgentRank = Rank,
			CorrectMatches = (Weaknesses.Length - copyWeaknesses.Count),
			TotalWeaknesses = Weaknesses.Length,
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