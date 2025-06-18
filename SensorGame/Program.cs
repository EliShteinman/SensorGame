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
				numberOfTeachings++;
				switch (agent.Rank)
				{
					case AgentRank.FootSoldier:
						var prompt = """
						             Choose a Sensor from the list.
						             1. Audio.
						             2. Pulse.
						             3. Thermal.
						             4. Exit.
						             """;
						var min = 1;
						var max = 4;
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
								return;
							default:
								throw new ArgumentOutOfRangeException();
						}
						ConsoleUtils.WriteLine("Choose a location");
						var location = int.Parse(Console.ReadLine());
						var sensor = SensorFactory.CreateSensorByType(sensorType);
						var count = agent.AttachSensor(sensor, location);
						ConsoleUtils.WriteLine($"Sensor exposed {count} times.");
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
			}
			ConsoleUtils.WriteLine($"Agent {agent.Rank} exposed {numberOfTeachings} times.");
		}
	}
}