using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities.TrackingSensors;

public class PulseSensor : TrackingSensor
{
	public PulseSensor()
	{
		Name = SensorType.Pulse;
	}
	public override SensorType Name { get; protected set; }
	public override void Activate()
	{

	}
}