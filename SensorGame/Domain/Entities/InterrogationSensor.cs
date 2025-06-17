using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities;

public abstract class InterrogationSensor : Isensor
{
	public abstract SensorType Name { get; protected set; }
	public string Type => "Interrogation";
	public abstract void Activate();
}