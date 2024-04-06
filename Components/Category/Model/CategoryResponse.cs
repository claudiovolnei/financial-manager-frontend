namespace FinancialManager.Web.Components.Category.Model;

public record struct CategoryResponse(
        int Id,
        string Name,
        int AccountTypeId,
        DateTime CreatedAt,
        DateTime UpdatedAt
    );