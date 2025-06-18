using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities;

public abstract class Sensor
{
	protected SensorType Type;
	protected bool IsBroken;
	public abstract SensorActiveResult Activate();
}