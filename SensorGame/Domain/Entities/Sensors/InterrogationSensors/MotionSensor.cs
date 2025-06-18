using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors.InterrogationSensors;

public class MotionSensor : InterrogationSensor
{
	public MotionSensor()
	{
		IsBroken = false;
		Type = SensorType.Motion;
	}

	public override SensorActiveResult Activate()
	{
		throw new NotImplementedException();
	}
}