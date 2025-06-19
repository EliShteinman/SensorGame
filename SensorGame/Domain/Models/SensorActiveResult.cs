using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Models;

public class SensorActiveResult
{
	public int ActivationCount { get; set; }
	public SensorType Type { get; set; }
	public bool WasBroken { get; set; }

	public int SlotIndex { get; set; }
}