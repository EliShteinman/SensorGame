using SensorGame.Domain.Enum;
using SensorGame.Domain.Interfaces;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors;

public abstract class InterrogationSensor : Isensor
{
	public abstract SensorType Name { get; protected set; }
	public bool IsBroken => false;
	public string Type => "Interrogation";
	public abstract SensorExecutionResult Activate(IranAgent agent);
}