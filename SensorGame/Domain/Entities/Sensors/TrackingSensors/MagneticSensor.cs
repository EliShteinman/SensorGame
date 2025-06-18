using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors.TrackingSensors;

public class MagneticSensor : TrackingSensor
{
	public MagneticSensor()
	{
		IsBroken = false;
		Type = SensorType.Magnetic;
	}

	public override SensorActiveResult Activate()
	{
		countActive++;
		if (countActive > 3)
		{
			IsBroken = true;
		}
		return new SensorActiveResult
		{
			Type = Type,
			WasBroken = IsBroken,
			ActivationCount = countActive
		};
	}
}