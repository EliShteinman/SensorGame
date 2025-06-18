using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors.TrackingSensors;

public class AudioSensor : TrackingSensor
{
	public AudioSensor()
	{
		IsBroken = false;
		Type = SensorType.Audio;
	}
	public override SensorActiveResult Activate()
	{
		return new SensorActiveResult
		{
			Type = Type,
			WasBroken = IsBroken
		};
	}
}