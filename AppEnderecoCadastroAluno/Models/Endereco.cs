using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEnderecoCadastroAluno.Models
{
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }
        [Required]
        public string Rua { get; set; }
        [Required]
        public string Cidade { get; set; }

        
        public int AlunoId { get; set; }
        public virtual Aluno? Aluno { get; set; }
    }
}
