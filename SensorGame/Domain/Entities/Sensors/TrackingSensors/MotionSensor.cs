using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors.TrackingSensors;

public class MotionSensor : TrackingSensor
{
	public MotionSensor()
	{
		IsBroken = false;
		Type = SensorType.Motion;
	}

	public override SensorActiveResult Activate()
	{
		CountActive++;
		if (CountActive > 3)
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