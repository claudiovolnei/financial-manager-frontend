using FinancialManager.Web.Components.Category.Model;

namespace FinancialManager.Web.Components.SubCategory.Model;

public record struct SubcategoryResponse(
        int Id,
        string Name,
        CategoryResponse Category,
        DateTime CreatedAt,
        DateTime UpdatedAt
    );