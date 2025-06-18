using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors.InterrogationSensors;

public class SignalSensor : InterrogationSensor
{
	public SignalSensor()
	{
		IsBroken = false;
		Type = SensorType.Signal;
	}

	public override SensorActiveResult Activate()
	{
		throw new NotImplementedException();
	}
}