using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMvcFuncional.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres")]
        [Display(Name = "Nome completo")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo  {0} é obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "O campo {0} precisa ter no máximo {1} caracteres")]
        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo  {0} é obrigatório")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = " O campo {0} precisa ter entre {2} e {1} caracteres")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "O campo {0} está em formato inválido")]
        //Também pode ser feito desse jeito --> [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo  {0} é obrigatório")]
        [Compare("Email", ErrorMessage = "Os e-mails informados não são idênticos")]
        [Display(Name = "Confirme o e-mail")]
        [NotMapped]
        public string? EmailConfirmacao { get; set; }


        [Required(ErrorMessage = "O campo  {0} é obrigatório")]
        [Range(1, 5, ErrorMessage = "O campo {0} deve estar entre {1} e {2}")]
        [Display(Name = "Avaliação")]
        public int Avaliacao { get; set; }

        [Display(Name = "Status")]
        public bool Ativo { get; set; }

    }
}
