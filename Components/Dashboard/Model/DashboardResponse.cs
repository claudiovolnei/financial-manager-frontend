namespace FinancialManager.Web.Components.Dashboard.Model
{
    public record struct DashboardResponse(
        decimal Amount,
        decimal Entrys,
        decimal Outputs,
        List<CategoriesGroup> Categories);
}

public record struct CategoriesGroup(string Item1, decimal Item2);