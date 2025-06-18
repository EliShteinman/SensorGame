using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors.InterrogationSensors;

public class LightSensor : InterrogationSensor
{
	public LightSensor()
	{
		IsBroken = false;
		Type = SensorType.Light;
	}
	public override SensorActiveResult Activate()
	{
		throw new NotImplementedException();
	}
}