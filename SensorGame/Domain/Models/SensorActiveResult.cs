using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Models;

public class SensorActiveResult
{
	public SensorType Type { get; set; }
	public bool WasBroken { get; set; }
}