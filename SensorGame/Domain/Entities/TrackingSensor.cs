namespace SensorGame.Domain.Entities;

public abstract class TrackingSensor : Isensor
{
	public abstract string Name { get; protected set; }
	public string Type => "Tracking";
	public abstract void Activate();
}