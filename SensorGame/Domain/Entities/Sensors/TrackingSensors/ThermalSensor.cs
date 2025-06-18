using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors.TrackingSensors;

public class ThermalSensor : TrackingSensor
{
	public ThermalSensor()
	{
		IsBroken = false;
		Type = SensorType.Thermal;
	}
	public override SensorActiveResult Activate()
	{
		countActive++;
		return new SensorActiveResult
		{
			Type = Type,
			WasBroken = IsBroken,
			ActivationCount = countActive
		};
	}
}