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