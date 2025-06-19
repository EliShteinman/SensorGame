using SensorGame.Domain.Entities;
using SensorGame.Domain.Enum;
using SensorGame.Utils;
namespace SensorGame.Logic;

public static class FootSolider
{
	public static void Run(IranAgent agent)
	{
		const string promptSensors = """
		                             Choose a Sensor from the list.
		                             1. Audio.
		                             2. Pulse.
		                             3. Thermal.
		                             4. Magnetic.
		                             5. Exit.
		                             """;
		const int minSensors = 1;
		const int maxSensors = 5;
		ConsoleUtils.Clear();
		var inputSensor = ConsoleUtils.GetChoice(promptSensors, minSensors, maxSensors);
		SensorType sensorType;
		switch (inputSensor)
		{
			case 1:
				sensorType = SensorType.Audio;
				break;
			case 2:
				sensorType = SensorType.Pulse;
				break;
			case 3:
				sensorType = SensorType.Thermal;
				break;
			case 4:
				sensorType = SensorType.Magnetic;
				break;
			case 5:
				return;
			default:
				throw new ArgumentOutOfRangeException();
		}
		const string promptLocation = "Choose a location";
		const int minLocation = 0;
		const int maxLocation = 1;
		var location = ConsoleUtils.GetChoice(promptLocation, minLocation, maxLocation);
		var sensor = SensorFactory.CreateSensorByType(sensorType);
		var result = agent.AttachSensor(sensor, location);
		ConsoleUtils.WriteLine(
			$"""
			 Rank = {result.AgentRank} 
			 Exposed {result.CorrectMatches}
			 From {result.TotalWeaknesses} weaknesses.

			 Press any key to continue.
			 """
		);
		Console.ReadKey(true);
	}
}