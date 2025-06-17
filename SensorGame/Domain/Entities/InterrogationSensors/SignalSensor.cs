using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities.TrackingSensors;

public class SignalSensor : InterrogationSensor
{
	public SignalSensor()
	{
		Name = SensorType.Signal;
	}
	public override SensorType Name { get; protected set; }
	public override void Activate()
	{
	}
}