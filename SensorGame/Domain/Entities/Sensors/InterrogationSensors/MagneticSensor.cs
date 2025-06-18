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
		throw new NotImplementedException();
	}
}