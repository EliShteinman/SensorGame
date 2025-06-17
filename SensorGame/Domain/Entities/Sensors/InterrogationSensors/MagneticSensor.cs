using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors.InterrogationSensors;

public class MagneticSensor : InterrogationSensor
{
	public MagneticSensor()
	{
		Name = SensorType.Magnetic;
	}
	public override SensorType Name { get; protected set; }
	public override SensorExecutionResult Activate(IranAgent agent)
	{
		throw new NotImplementedException();
	}
}