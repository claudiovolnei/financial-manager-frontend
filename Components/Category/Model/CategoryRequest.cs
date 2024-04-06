using System.ComponentModel.DataAnnotations;

namespace FinancialManager.Web.Components.Category.Model;

public record struct CategoryRequest(
        int? Id,
        string Name,
        int AccountTypeId
);

public record struct Category()
{        
        public int? Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatória.")]
        [StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
        public string Name { get; set; }
        [Required (ErrorMessage = "Tipo de conta é obrigatória.")]
        public int AccountTypeId { get; set; }
}