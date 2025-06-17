using SensorGame.Domain.Entities.Sensors;
using SensorGame.Domain.Enum;
using SensorGame.Domain.Interfaces;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities;

public abstract class IranAgent
{
	protected readonly TrackingSensor[] AttachedSensors;
	protected readonly TrackingSensor[] Weaknesses;

	protected IranAgent(TrackingSensor[] weaknesses)
	{
		Weaknesses = weaknesses;
		AttachedSensors = new TrackingSensor[weaknesses.Length];
	}
	public abstract AgentRank Rank { get; }
	public bool IsExposed => false;
	public abstract InvestigationAggregateResult Investigate();
	public abstract string AttachSensor(Isensor sensor, int? Location);
}