using HydroSmart.API.Analytics.Domain.Model.Aggregates;
using HydroSmart.API.Analytics.Domain.Model.Commands;
using HydroSmart.API.Analytics.Domain.Model.Queries;
using HydroSmart.API.Analytics.Interfaces.REST.Resources;

namespace HydroSmart.API.Analytics.Interfaces.REST.Transform;

public static class WaterConsumptionRecordResourceFromEntityAssembler
{
    public static WaterConsumptionRecordResource ToResourceFromEntity(WaterConsumptionRecord record)
    {
        return new WaterConsumptionRecordResource
        {
            Id = record.Id,
            UserId = record.UserId,
            Liters = record.Liters,
            Category = record.Category,
            RecordedAt = record.RecordedAt
        };
    }
}

public static class CreateWaterConsumptionRecordCommandFromResourceAssembler
{
    public static CreateWaterConsumptionRecordCommand ToCommandFromResource(CreateWaterConsumptionRecordRequest resource)
    {
        return new CreateWaterConsumptionRecordCommand(
            resource.UserId,
            resource.Liters,
            resource.Category,
            resource.RecordedAt
        );
    }
}
