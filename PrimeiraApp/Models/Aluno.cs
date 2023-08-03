using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiraApp.Models {
    public class Aluno {
        //Identificação
        [Key]
        public int Id { get; set; }

        //Nome do aluno
        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [StringLength(30,MinimumLength = 2,ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres")]
        public string? Nome { get; set; }

        //Data de nascimento
        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [DataType(DataType.DateTime,ErrorMessage = "O campo {0} esta em formato incorreto")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        //Email
        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [StringLength(60, ErrorMessage = "O campo {0} precisa ter no maximo {1} caracteres")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$",ErrorMessage = "O campo {0} está em formato invalido.")]
        //Outra opcao para validacao de formato de email:
        //[EmailAddress(ErrorMessage = "O campo {0} esta em formato incorreto")]
        public string? Email { get; set; }

        //Email de confirmação
        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [Display(Name = "Confirme o email")]
        [Compare("Email", ErrorMessage = "Os emails informados nao sao identicos")]
        [NotMapped]
        public string? EmailConfirmacao { get; set; }

        //Avaliação aluno
        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [Range(1,5, ErrorMessage = "O campo {0} deve estar entre {1} e {2}")]
        public int Avaliacao { get; set; }

        //Ativo
        public bool Ativo { get; set; }
    }
}
