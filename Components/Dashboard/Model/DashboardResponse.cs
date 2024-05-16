namespace FinancialManager.Web.Components.Dashboard.Model
{
    public record struct DashboardResponse(
        decimal Amount,
        decimal Entrys,
        decimal Outputs,
        List<Tuple<string, decimal>> Categories);
}