using System.ComponentModel.DataAnnotations;
using FinancialManager.Web.Components.SubCategory.Model;

namespace FinancialManager.Web.Components.Transaction.Model;

public record struct TransactionOrderReponse(
        int Id,
        string Title,
        double ValuePayment,
        SubcategoryResponse Subcategory,
        TypeCard TypeCard,
        DateTime? DateOrder,
        DateTime? DatePayment
);

public enum TypeCard {
    [Display (Name = "")]
    Vazio = 0,
    [Display(Name = "Cartão de Debito")]
    DebitCard = 1,
    [Display(Name = "Cartão de Crédito")]
    CreditCard = 2
}