namespace SensorGame.Domain.Models;

public class InvestigationAggregateResult
{
	public int CorrectMatches { get; set; }       // סכום הפגיעות הנכונות
	public int TotalWeaknesses { get; set; }      // תמיד ידוע לפי סוג סוכן
	public bool IsVictory => CorrectMatches == TotalWeaknesses;
	public List<SensorExecutionResult> InternalSensorResults { get; set; } // ניתוח פנימי בלבד
}