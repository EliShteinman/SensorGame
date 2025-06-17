using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities;

public abstract class TrackingSensor : Isensor
{
	public abstract SensorType Name { get; protected set; }
	public string Type => "Tracking";
	public abstract void Activate();
}