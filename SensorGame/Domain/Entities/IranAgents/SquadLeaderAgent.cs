using SensorGame.Domain.Entities.Sensors;
using SensorGame.Domain.Enum;
using SensorGame.Domain.Interfaces;
using SensorGame.Domain.Models;

namespace SensorGame.Domain.Entities.IranAgents;

public class SquadLeaderAgent : IranAgent
{
	public SquadLeaderAgent()
	{
		Weaknesses = new TrackingSensor[4];
		AttachedSensors = new TrackingSensor[Weaknesses.Length];
	}
	public override AgentRank Rank => AgentRank.SquadLeader;

	public override InvestigationAggregateResult Investigate()
	{
		throw new NotImplementedException();
	}
	public override string AttachSensor(Isensor sensor, int? Location)
	{
		throw new NotImplementedException();
	}
}