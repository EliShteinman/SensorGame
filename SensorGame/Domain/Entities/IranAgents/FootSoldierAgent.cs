using SensorGame.Domain.Enum;
using SensorGame.Domain.Interfaces;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities.IranAgents;

public class FootSoldierAgent : IranAgent
{
	public FootSoldierAgent() :
			base(SensorFactory.CreateRandomWeaknessSensors(2))
	{
	}
	public override AgentRank Rank => AgentRank.FootSoldier;

	public override InvestigationAggregateResult Investigate()
	{
		throw new NotImplementedException();
	}
	public override string AttachSensor(Isensor sensor, int? Location)
	{
		throw new NotImplementedException();
	}
}