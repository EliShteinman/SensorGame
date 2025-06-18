using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors;

public abstract class InterrogationSensor : Sensor
{
	public string Category => "Interrogation";
}