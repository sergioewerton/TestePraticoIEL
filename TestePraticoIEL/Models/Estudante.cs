using System.ComponentModel.DataAnnotations; // Necessário para as validações

namespace CadastroIEL.Models // Certifique-se que o namespace está igual ao nome do seu projeto
{
    public class Estudante
    {
        public int Id { get; set; } // Chave primária para o banco

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Formato de CPF inválido. Use 000.000.000-00")]
        public string? CPF { get; set; }

        [StringLength(200, ErrorMessage = "O endereço deve ter no máximo 200 caracteres.")]
        public string? Endereco { get; set; }

        [Required(ErrorMessage = "A data de conclusão é obrigatória.")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Conclusão")]
        public DateTime DataConclusao { get; set; }
    }
}
