namespace FinancialManager.Web.Components.Dashboard.Model
{
    public record struct DashboardResponse(
        decimal Amount,
        decimal Entrys,
        decimal Outputs,
        List<(string Item1, decimal Item2)> Categories);
}