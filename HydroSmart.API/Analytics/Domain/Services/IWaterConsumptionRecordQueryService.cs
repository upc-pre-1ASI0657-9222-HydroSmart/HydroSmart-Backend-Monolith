using HydroSmart.API.Analytics.Domain.Model.Queries;

namespace HydroSmart.API.Analytics.Domain.Services;
// interface to define the contract for querying water consumption records
public interface IWaterConsumptionRecordQueryService
{
    Task<double> Handle(GetTodayConsumptionByUserIdQuery query);
    Task<IEnumerable<TimeBlockConsumption>> Handle(GetDailyConsumptionByUserIdQuery query);
    Task<IEnumerable<CategoryConsumption>> Handle(GetConsumptionByCategoryQuery query);
    Task<IEnumerable<MonthlyConsumption>> Handle(GetMonthlyComparisonQuery query);
    Task<MonthlyTotalAndGoal> Handle(GetMonthlyTotalAndGoalQuery query);
}
