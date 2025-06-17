using SensorGame.Domain.Enum;

namespace SensorGame.Domain.Entities.IranAgents;

public class SquadLeaderAgent : IranAgent
{
	public SquadLeaderAgent()
	{
		Weaknesses = new TrackingSensor[4];
		AttachedSensors = new TrackingSensor[Weaknesses.Length];
	}
	public override AgentRank Rank => AgentRank.SquadLeader;

	public override string Investigate()
	{
		throw new NotImplementedException();
	}
	public override string AttachSensor(Isensor sensor, int? Location)
	{
		throw new NotImplementedException();
	}
}