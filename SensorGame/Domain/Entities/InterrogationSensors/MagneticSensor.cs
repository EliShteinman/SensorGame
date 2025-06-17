namespace SensorGame.Domain.Entities.TrackingSensors;

public class MagneticSensor : InterrogationSensor
{
	public MagneticSensor()
	{
		Name = "Magnetic";
	}
	public override string Name { get; protected set; }
	public override void Activate()
	{}
}