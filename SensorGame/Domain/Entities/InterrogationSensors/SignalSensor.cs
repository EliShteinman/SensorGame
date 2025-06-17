namespace SensorGame.Domain.Entities.TrackingSensors;

public class SignalSensor : InterrogationSensor
{
	public SignalSensor()
	{
		Name = "Signal";
	}
	public override string Name { get; protected set; }
	public override void Activate()
	{}
}