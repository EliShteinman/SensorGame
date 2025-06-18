using SensorGame.Domain.Enum;
using SensorGame.Domain.Entities;
using SensorGame.Utils;

namespace SensorGame.Logic;

public class SquadLeader
{
	public static void Run(IranAgent agent)
	{
		var prompt = """
		             Choose a Sensor from the list.
		             1. Audio.
		             2. Pulse.
		             3. Thermal.
		             4. Magnatic.
		             5. Motion
		             6. Exit.
		             """;
		var min = 1;
		var max = 6;
		ConsoleUtils.Clear();
		var inputSensor = ConsoleUtils.GetChoice(prompt, min, max);
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
				sensorType = SensorType.Motion;
				break;
			case 6:
				return;
			default:
				throw new ArgumentOutOfRangeException();
		}
		var promptLocation = "Choose a location";
		var minLocation = 0;
		var maxLocation = 1;
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