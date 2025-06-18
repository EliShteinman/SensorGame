using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors.TrackingSensors;

public class PulseSensor : TrackingSensor
{
	public PulseSensor()
	{
		IsBroken = false;
		Type = SensorType.Pulse;
	}
	public override SensorActiveResult Activate()
	{
		throw new NotImplementedException();
	}
}