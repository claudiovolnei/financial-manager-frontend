using System.ComponentModel.DataAnnotations;

namespace FinancialManager.Web.Components.Category.Model;

public record struct CategoryRequest()
{        
        public int? Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatória.")]
        public string Name { get; set; }
        [Required (ErrorMessage = "Tipo de conta é obrigatória.")]
        public int AccountTypeId { get; set; }
}