﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMvcFuncional.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo  {0} é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = " O campo {0} precisa ter entre {1} e {30} caracteres}")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo  {0} é obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = " O campo {0} precisa ter no máximo {1} caracteres}")]
        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo  {0} é obrigatório")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = " O campo {0} precisa ter entre {1} caracteres}")]
        [RegularExpression(@"^([\w-\.]+@([\w\-]+\.)+[\w-] {2,4}$", ErrorMessage = "O campo {0} está em formato inválido")]
        //Também pode ser feito desse jeito --> [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo  {0} é obrigatório")]
        [Display(Name = "Confirme o e-mail")]
        [Compare("Email", ErrorMessage = "Os e-mails informados não são idênticos")]
        [NotMapped]
        public string? EmailConfirmacao { get; set; }


        [Required(ErrorMessage = "O campo  {0} é obrigatório")]
        [Range(1, 5, ErrorMessage = "O campo {0} deve estrar entre {1} e {5}")]
        public int Avaliacao { get; set; }

        public bool Ativo { get; set; }

    }
}
