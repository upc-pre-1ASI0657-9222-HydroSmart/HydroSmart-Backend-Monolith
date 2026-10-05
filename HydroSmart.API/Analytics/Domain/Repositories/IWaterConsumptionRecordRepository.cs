using HydroSmart.API.Analytics.Domain.Model.Aggregates;
using HydroSmart.API.Shared.Domain.Repositories;

namespace HydroSmart.API.Analytics.Domain.Repositories;
// interface to define the contract for water consumption record repository
public interface IWaterConsumptionRecordRepository : IBaseRepository<WaterConsumptionRecord>
{
    Task<IEnumerable<WaterConsumptionRecord>> FindByUserIdAsync(int userId);
    Task<IEnumerable<WaterConsumptionRecord>> FindByUserIdAndDateRangeAsync(int userId, DateTime from, DateTime to);
}
