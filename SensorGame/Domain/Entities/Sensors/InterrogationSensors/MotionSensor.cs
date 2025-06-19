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
		CountActive++;
		if (CountActive > 2)
		{
			IsBroken = true;
		}
		return new SensorActiveResult
		{
			Type = Type,
			WasBroken = IsBroken,
			ActivationCount = CountActive
		};
	}
}