using SensorGame.Domain.Entities.Sensors;
using SensorGame.Domain.Enum;
using SensorGame.Domain.Interfaces;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities;

public abstract class IranAgent
{
	public abstract AgentRank Rank { get; }
	protected TrackingSensor[] Weaknesses;
	protected TrackingSensor[] AttachedSensors;
	public bool IsExposed => false;
	public abstract InvestigationAggregateResult Investigate();
	public abstract string AttachSensor(Isensor sensor, int? Location);
}