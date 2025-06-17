namespace SensorGame.Domain.Entities.TrackingSensors;

public class AudioSensor : TrackingSensor
{
	public AudioSensor()
	{
		Name = "Audio";
	}
	public override string Name { get; protected set; }
	public override void Activate()
	{

	}
}