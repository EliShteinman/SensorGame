using SensorGame.Domain.Entities.TrackingSensors;
using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities;

public static class SensorFactory
{
	private static readonly Random Random = new();
	public static Isensor[] CreateAllSensors()
	{
		return
		[
			new AudioSensor(),
			new PulseSensor(),
			new ThermalSensor(),
			new MotionSensor(),
			new SignalSensor(),
			new MagneticSensor(),
			new LightSensor()
		];
	}

	public static Isensor[] CreateInvestigatorSensors()
	{
		return
		[
			new MotionSensor(),
			new SignalSensor(),
			new MagneticSensor(),
			new LightSensor()
		];
	}

	public static Isensor[] CreateWeaknessSensors()
	{
		return
		[
			new AudioSensor(),
			new PulseSensor(),
			new ThermalSensor()
		];
	}
	public static Isensor[] CreateRandomWeaknessSensors(int count)
	{
		var baseOptions = CreateWeaknessSensors();
		var result = new List<Isensor>();
		for (var i = 0; i < count; i++)
		{
			var randomIndex = Random.Next(0, baseOptions.Length);
			result.Add(baseOptions[randomIndex]);
		}
		return result.ToArray();
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