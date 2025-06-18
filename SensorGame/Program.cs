using SensorGame.Domain.Entities;
using SensorGame.Domain.Enum;
using SensorGame.Utils;
namespace SensorGame;

class Program
{
	private static void Main()
	{
		while (true)
		{
			var numberOfTeachings = 0;
			var agent = AgentFactory.CreateAgentByType(AgentRank.FootSoldier);
			while (!agent.IsExposed)
			{
				switch (agent.Rank)
				{
					case AgentRank.FootSoldier:
						var prompt = """
						             Choose a Sensor from the list.
						             1. Audio.
						             2. Pulse.
						             3. Thermal.
						             4. Motion.
						             5. Exit.
						             """;
						var min = 1;
						var max = 5;
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
								sensorType = SensorType.Motion;
								break;
							case 5:
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
							"""
						);
						break;
					case AgentRank.SquadLeader:
						break;
					case AgentRank.SeniorCommander:
						break;
					case AgentRank.OrganizationLeader:
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
				numberOfTeachings++;
			}
			ConsoleUtils.WriteLine($"Agent {agent.Rank} exposed {numberOfTeachings} times.");
		}
	}
}