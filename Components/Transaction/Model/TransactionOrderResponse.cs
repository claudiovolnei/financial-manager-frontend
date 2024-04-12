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
    [Display(Name = "Conta Corrente")]
    DebitCard = 1,
    [Display(Name = "Cartão de Crédito")]
    CreditCard = 2
}

public enum TypeTransaction {
    [Display (Name = "Debito")]
    Debit = 1,
    [Display (Name = "Crédito")]
    Credit = 2
}