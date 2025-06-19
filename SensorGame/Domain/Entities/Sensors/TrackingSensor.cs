namespace SensorGame.Domain.Entities.Sensors;

public abstract class TrackingSensor : Sensor
{
	protected int CountActive = 0;
	public string Category => "Tracking";
}