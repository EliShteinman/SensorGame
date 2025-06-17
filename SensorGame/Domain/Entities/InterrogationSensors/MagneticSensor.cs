using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities.TrackingSensors;

public class MagneticSensor : InterrogationSensor
{
	public MagneticSensor()
	{
		Name = SensorType.Magnetic;
	}
	public override SensorType Name { get; protected set; }
	public override void Activate()
	{
	}
}