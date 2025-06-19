using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors.InterrogationSensors;

public class MagneticSensor : InterrogationSensor
{
	public MagneticSensor()
	{
		IsBroken = false;
		Type = SensorType.Magnetic;
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