namespace SensorGame.Domain.Entities.TrackingSensors;

public class LightSensor : InterrogationSensor
{
	public LightSensor()
	{
		Name = "Light";
	}
	public override string Name { get; protected set; }
	public override void Activate()
	{}
}