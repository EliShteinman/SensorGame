using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Models;

public class SensorExecutionResult
{
	public bool WasActivated { get; set; } // האם הופעל בפועל (ולא נחסם / שבור)
	public bool WasBlocked { get; set; } // האם נחסם (אם יש חסימות עתידיות)
	public bool WasBroken { get; set; } // האם נשבר כתוצאה מההפעלה הזו
	public bool WasCorrectMatch { get; set; } // האם פגע במקום הנכון
	public bool TriggeredCounterAttack { get; set; } // האם גרם להתקפה נגד
	public SensorType SensorType { get; set; } // אפשרי אם תצטרך לזיהוי
}