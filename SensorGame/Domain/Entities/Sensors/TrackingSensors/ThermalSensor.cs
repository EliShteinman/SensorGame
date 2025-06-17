using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors.TrackingSensors;

public class ThermalSensor : TrackingSensor
{
	public ThermalSensor()
	{
		Name = SensorType.Thermal;
	}
	public override SensorType Name { get; protected set; }
	public override SensorExecutionResult Activate(IranAgent agent)
	{
		throw new NotImplementedException();
	}
}