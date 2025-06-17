namespace SensorGame.Domain.Entities.TrackingSensors;

public class MotionSensor : InterrogationSensor
{
	public MotionSensor()
	{
		Name = "Motion";
	}
	public override string Name { get; protected set; }
	public override void Activate()
	{}
}