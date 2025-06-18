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