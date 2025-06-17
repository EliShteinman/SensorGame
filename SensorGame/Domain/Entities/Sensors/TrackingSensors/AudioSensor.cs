using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities.Sensors.TrackingSensors;

public class AudioSensor : TrackingSensor
{
	public AudioSensor()
	{
		Name = SensorType.Audio;
	}
	public override SensorType Name { get; protected set; }
	public override void Activate()
	{

	}
}