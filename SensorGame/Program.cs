using SensorGame.Domain.Entities;
using SensorGame.Domain.Enum;
using SensorGame.Domain.Interfaces;
namespace SensorGame;

class Program
{
	private static void Main()
	{
		var numberOfTeachings = 0;
		while (true)
		{
			var agent = AgentFactory.CreateAgentByType(AgentRank.FootSoldier);
			while (!agent.IsExposed)
			{
				numberOfTeachings++;
				switch (agent.Rank)
				{
					case AgentRank.FootSoldier:
						var prompt = """
						             Choose a sensor from the list.
						             1. Audio.
						             2. Pulse.
						             3. Thermal.
						             4. Exit.
						             """;
						var min = 1; 
						var max = 4;
						var inputSensor = Utils.ConsoleUtils.GetChoice(prompt, min, max);
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
						Console.WriteLine("Choose a location");
						var location = int.Parse(Console.ReadLine());
						var sensor = SensorFactory.CreateSensorByType(sensorType);
						agent.AttachSensor(sensor, location);
						
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
		}
	}
}