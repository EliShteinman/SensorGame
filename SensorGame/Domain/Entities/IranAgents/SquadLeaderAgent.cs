using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.IranAgents;

public class SquadLeaderAgent : IranAgent
{
	private readonly Random Random = new();
	private int CounterOfInvestigations = 0;
	private void Remove1Sensor()
	{
		AttachedSensors[Random.Next(0, AttachedSensors.Length)] = null;
	}
	public SquadLeaderAgent()
			: base(WeaknessesFactory.CreateRandomWeakness(4))
	{
	}
	public override AgentRank Rank => AgentRank.SquadLeader;

	protected override InvestigationAggregateResult Investigate()
	{
		CounterOfInvestigations++;
		if (CounterOfInvestigations % 3 == 0)
		{
			Remove1Sensor();
		}
		var brokenCount = 0;
		var results = new List<SensorActiveResult>();
		var copyWeaknesses = Weaknesses.ToList();
		foreach (var sensor in AttachedSensors)
		{
			if (sensor == null)
			{
				continue;
			}
			var result = sensor.Activate();
			if (result.WasBroken)
			{
				brokenCount++;
			}
			else
			{
				copyWeaknesses.Remove(result.Type);
			} 
			results.Add(result);
		}
		IsExposed = (copyWeaknesses.Count == 0);
		return new InvestigationAggregateResult
		{
			AgentRank = Rank,
			CorrectMatches = (Weaknesses.Length - copyWeaknesses.Count),
			TotalWeaknesses = Weaknesses.Length,
			InternalSensorResults = results,
			BrokenCount = brokenCount
		};
	}
}