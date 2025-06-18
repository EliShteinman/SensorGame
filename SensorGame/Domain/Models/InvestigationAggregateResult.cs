using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Models;

public class InvestigationAggregateResult
{
	public AgentRank AgentRank { get; set; }
	public int CorrectMatches { get; set; }
	public int BrokenCount {get; set;}
	public int TotalWeaknesses { get; set; }
	public bool IsVictory => CorrectMatches == TotalWeaknesses;
	public List<SensorActiveResult> InternalSensorResults { get; set; }
}