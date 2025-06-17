using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities.Sensors.InterrogationSensors;

public class LightSensor : InterrogationSensor
{
	public LightSensor()
	{
		Name = SensorType.Light;
	}
	public override SensorType Name { get; protected set; }
	public override void Activate()
	{
	}
}