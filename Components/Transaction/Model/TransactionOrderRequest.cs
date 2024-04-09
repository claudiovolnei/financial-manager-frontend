using FinancialManager.Web.Components.SubCategory.Model;

namespace FinancialManager.Web.Components.Transaction.Model;

public record struct TransactionOrderRequest(
        int? Id,
        string Title,
        double ValuePayment,
        int SubcategoryId,
        TypeCard TypeCard,
        DateTime? DateOrder,
        DateTime? DatePayment
);