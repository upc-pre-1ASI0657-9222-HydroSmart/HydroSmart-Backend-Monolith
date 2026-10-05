namespace HydroSmart.API.Analytics.Domain.Model.Commands;
// Command value objects
public record CreateWaterConsumptionRecordCommand(
    int UserId,
    double Liters,
    string Category,
    DateTime? RecordedAt
);
