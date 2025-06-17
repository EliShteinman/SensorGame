namespace SensorGame.Domain.Entities.TrackingSensors;

public class PulseSensor : TrackingSensor
{
	public PulseSensor()
	{
		Name = "Pulse";
	}
	public override string Name { get; protected set; }
	public override void Activate()
	{

	}
}