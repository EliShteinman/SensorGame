using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities;

public abstract class IranAgent
{
	public abstract AgentRank Rank { get; }
	protected TrackingSensor[] Weaknesses;
	protected TrackingSensor[] AttachedSensors;
	public bool IsExposed => false;
	public abstract string Investigate();
	public abstract string AttachSensor(Isensor sensor, int? Location);
}