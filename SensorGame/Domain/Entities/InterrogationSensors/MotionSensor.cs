using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities.TrackingSensors;

public class MotionSensor : InterrogationSensor
{
	public MotionSensor()
	{
		Name = SensorType.Motion;
	}
	public override SensorType Name { get; protected set; }
	public override void Activate()
	{
	}
}