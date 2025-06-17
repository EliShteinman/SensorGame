using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors.TrackingSensors;

public class PulseSensor : TrackingSensor
{
	public PulseSensor()
	{
		Name = SensorType.Pulse;
	}
	public override SensorType Name { get; protected set; }
	public override SensorExecutionResult Activate(IranAgent agent)
	{
		throw new NotImplementedException();
	}
}