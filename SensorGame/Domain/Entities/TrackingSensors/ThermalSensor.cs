namespace SensorGame.Domain.Entities.TrackingSensors;

public class ThermalSensor : TrackingSensor
{
	public ThermalSensor()
	{
		Name = "Thermal";
	}
	public override string Name { get; protected set; }
	public override void Activate()
	{

	}
}