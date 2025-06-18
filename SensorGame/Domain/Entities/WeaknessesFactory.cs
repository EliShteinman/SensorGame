using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities;

public static class WeaknessesFactory
{
	private static readonly Random Random = new();
	private static readonly SensorType[] TrackingTypes = [
		SensorType.Audio, 
		SensorType.Pulse, 
		SensorType.Thermal, 
		SensorType.Magnetic
	];

	public static SensorType[] CreateRandomWeakness(int count)
	{
		var weakness = new SensorType[count];
		for (var i = 0; i < count; i++)
		{
			var type = TrackingTypes[Random.Next(0, TrackingTypes.Length)];
			weakness[i] = type;
		}
		return weakness;
	}
}