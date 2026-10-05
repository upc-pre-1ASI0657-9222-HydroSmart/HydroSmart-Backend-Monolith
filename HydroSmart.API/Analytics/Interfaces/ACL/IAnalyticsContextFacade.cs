using HydroSmart.API.Analytics.Interfaces.REST.Resources;
//class to convert MonthlyConsumption entity to MonthlyComparisonResource
namespace HydroSmart.API.Analytics.Interfaces.ACL;

public interface IAnalyticsContextFacade
{
    Task<DashboardResource> GetDashboard(int userId);
    Task<WaterConsumptionRecordResource?> CreateRecord(CreateWaterConsumptionRecordRequest request);
}
