using SensorGame.Domain.Entities.Sensors;
using SensorGame.Domain.Enum;
using SensorGame.Domain.Interfaces;

namespace SensorGame.Domain.Entities.IranAgents;

public class SeniorCommanderAgent : IranAgent
{
	public SeniorCommanderAgent()
	{
		Weaknesses = new TrackingSensor[6];
		AttachedSensors = new TrackingSensor[Weaknesses.Length];
	}
	public override AgentRank Rank => AgentRank.SeniorCommander;

	public override string Investigate()
	{
		throw new NotImplementedException();
	}
	public override string AttachSensor(Isensor sensor, int? Location)
	{
		throw new NotImplementedException();
	}
	
}