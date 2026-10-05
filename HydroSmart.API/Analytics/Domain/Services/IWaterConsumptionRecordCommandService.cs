using HydroSmart.API.Analytics.Domain.Model.Aggregates;
using HydroSmart.API.Analytics.Domain.Model.Commands;

namespace HydroSmart.API.Analytics.Domain.Services;
// interface to define the contract for handling water consumption record commands
public interface IWaterConsumptionRecordCommandService
{
    Task<WaterConsumptionRecord?> Handle(CreateWaterConsumptionRecordCommand command);
}
