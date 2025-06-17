using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors.InterrogationSensors;

public class MotionSensor : InterrogationSensor
{
	public MotionSensor()
	{
		Name = SensorType.Motion;
	}
	public override SensorType Name { get; protected set; }
	public override SensorExecutionResult Activate(IranAgent agent)
	{
		throw new NotImplementedException();
	}
}