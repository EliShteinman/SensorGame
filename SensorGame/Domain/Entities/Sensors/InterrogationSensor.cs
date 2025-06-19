namespace SensorGame.Domain.Entities.Sensors;

public abstract class InterrogationSensor : Sensor
{
	protected int CountActive = 0;
	public string Category => "Interrogation";
}