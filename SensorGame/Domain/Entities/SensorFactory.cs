using SensorGame.Domain.Entities.Sensors;
using SensorGame.Domain.Entities.Sensors.InterrogationSensors;
using SensorGame.Domain.Entities.Sensors.TrackingSensors;
using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities;

public static class SensorFactory
{
	private static readonly Random Random = new();
	private static readonly SensorType[] TrackingTypes = [SensorType.Audio, SensorType.Pulse, SensorType.Thermal, SensorType.Magnetic];
	private static readonly SensorType[] InterrogationTypes = [SensorType.Motion, SensorType.Signal, SensorType.Light];

	private static TrackingSensor CreateTrackingSensorByType(SensorType type)
	{
		switch (type)
		{
			case SensorType.Magnetic:
				return new MagneticSensor();
			case SensorType.Audio:
				return new AudioSensor();
			case SensorType.Pulse:
				return new PulseSensor();
			case SensorType.Thermal:
				return new ThermalSensor();
			default:
				throw new ArgumentException("Invalid sensor type");
		}
	}

	private static InterrogationSensor CreateInterrogationSensorByType(SensorType type)
	{
		switch (type)
		{
			case SensorType.Motion:
				return new MotionSensor();
			case SensorType.Signal:
				return new SignalSensor();
			case SensorType.Light:
				return new LightSensor();
			default:
				throw new ArgumentException("Invalid sensor type");
		}
	}
	public static Sensor CreateSensorByType(SensorType type)
	{
		if (TrackingTypes.Contains(type)) return CreateTrackingSensorByType(type);
		if (InterrogationTypes.Contains(type)) return CreateInterrogationSensorByType(type);
		throw new ArgumentException("Invalid sensor type");
	}
}