using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities.TrackingSensors;

public class ThermalSensor : TrackingSensor
{
	public ThermalSensor()
	{
		Name = SensorType.Thermal;
	}
	public override SensorType Name { get; protected set; }
	public override void Activate()
	{

	}
}