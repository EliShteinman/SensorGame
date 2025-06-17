using SensorGame.Domain.Entities.TrackingSensors;
using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities;

public static class SensorFactory
{
	private static readonly Random Random = new();
	public static Isensor[] CreateRandomWeaknessSensors(int count)
	{
		List<SensorType> types = [SensorType.Audio, SensorType.Pulse, SensorType.Thermal];
		var sensors = new Isensor[count];
		for (var i = 0; i < count; i++)
		{
			sensors[i] = CreateSensorByType(types[Random.Next(0, types.Count)]);
		}
		return sensors;
	}
	public static Isensor CreateSensorByType(SensorType type)
	{
		Isensor sensor = null;
		switch (type)
		{
			case SensorType.Audio:
				sensor = new AudioSensor();
				break;
			case SensorType.Pulse:
				sensor = new PulseSensor();
				break;
			case SensorType.Thermal:
				sensor = new ThermalSensor();
				break;
			case SensorType.Motion:
				sensor = new MotionSensor();
				break;
			case SensorType.Signal:
				sensor = new SignalSensor();
				break;
			case SensorType.Magnetic:
				sensor = new MagneticSensor();
				break;
			case SensorType.Light:
				sensor = new LightSensor();
				break;
			default:
				throw new ArgumentException("Invalid sensor type");
		}
		return sensor;
	}
}