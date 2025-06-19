using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities;

public abstract class Sensor
{
	protected bool IsBroken;
	protected SensorType Type;
	public abstract SensorActiveResult Activate();
}