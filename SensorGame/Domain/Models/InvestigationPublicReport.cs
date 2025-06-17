namespace SensorGame.Domain.Models;

public class InvestigationPublicReport
{
	public int CorrectMatches { get; set; }
	public int TotalWeaknesses { get; set; }
	public bool IsVictory => CorrectMatches == TotalWeaknesses;
	public string Message { get; set; } // לדוגמה: "פגעת ב-3 מתוך 6. המשך לחקור!"
}