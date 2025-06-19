using SensorGame.Domain.Entities;
using SensorGame.Domain.Enum;
using SensorGame.Logic;
using SensorGame.Utils;
namespace SensorGame;

static class Program
{
	private static void Main()
	{
		while (true)
		{
			var numberOfTeachings = 0;
			const string promptSoldier = """
			                             Choose an agent type to investigate:
			                             1.	Foot Soldier
			                             2.	Squad Leader
			                             3.	Senior Commander
			                             4.	[Not available] Organization Leader
			                             5.	Exit
			                             """;
			const int minSoldier = 1;
			const int maxSoldier = 5;
			var inputSoldier = ConsoleUtils.GetChoice(promptSoldier, minSoldier, maxSoldier);
			AgentRank rank;
			switch (inputSoldier)
			{
				case 1:
					rank = AgentRank.FootSoldier;
					break;
				case 2:
					rank = AgentRank.SquadLeader;
					break;
				case 3:
					rank = AgentRank.SeniorCommander;
					break;
				case 4:
					throw new NotImplementedException();
				case 5:
					return;
				default:
					throw new ArgumentOutOfRangeException();
			}
			var agent = AgentFactory.CreateAgentByType(rank);
			while (!agent.IsExposed)
			{
				switch (agent.Rank)
				{
					case AgentRank.FootSoldier:
						FootSolider.Run(agent);
						break;
					case AgentRank.SquadLeader:
						SquadLeader.Run(agent);
						break;
					case AgentRank.SeniorCommander:
						SeniorCommander.Run(agent);
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