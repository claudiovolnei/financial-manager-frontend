namespace FinancialManager.Web.Layout;
public class ServiceStateCategory
{
    public event EventHandler? EventClick;
    public void GetCategoriesService(object sender) 
    {
        if (EventClick != null)
            this.EventClick(sender, EventArgs.Empty);
    }
}
