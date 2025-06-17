using SensorGame.Domain.Enum;

namespace SensorGame.Domain.Entities.IranAgents;

public class OrganizationLeaderAgent : IranAgent
{
	public OrganizationLeaderAgent()
	{
		Weaknesses = new TrackingSensor[8];
		AttachedSensors = new TrackingSensor[Weaknesses.Length];
	}
	public override AgentRank Rank => AgentRank.OrganizationLeader;

	public override string Investigate()
	{
		throw new NotImplementedException();
	}
	public override string AttachSensor(Isensor sensor, int? Location)
	{
		throw new NotImplementedException();
	}
}