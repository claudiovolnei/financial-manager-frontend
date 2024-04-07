namespace FinancialManager.Web.Components.Category.Model;

public record struct CategoryResponse(
        int Id,
        string Name,
        AccountType AccountType,
        DateTime CreatedAt,
        DateTime UpdatedAt
    );

public record struct AccountType(int Id, string Name);