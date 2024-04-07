using System.ComponentModel.DataAnnotations;

namespace FinancialManager.Web.Components.SubCategory.Model;

public record struct SubcategoryRequest()
{        
        public int? Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatória.")]
        public string Name { get; set; }
        [Required (ErrorMessage = "Categoria é obrigatória.")]
        public int CategoryId { get; set; }
}