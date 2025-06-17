using SensorGame.Domain.Enum;
using SensorGame.Domain.Interfaces;
namespace SensorGame.Domain.Entities.Sensors;

public abstract class TrackingSensor : Isensor
{
	public abstract SensorType Name { get; protected set; }
	public bool IsBroken => false;
	public string Type => "Tracking";
	public abstract void Activate();
}