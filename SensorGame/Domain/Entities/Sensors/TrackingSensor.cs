using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.Sensors;

public abstract class TrackingSensor : Sensor
{
	protected int countActive = 0;
	public string For => "Tracking";
	
}