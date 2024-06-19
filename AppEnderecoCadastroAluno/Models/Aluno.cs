using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEnderecoCadastroAluno.Models
{
    public class Aluno
    {
        [Key]
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }

        [ForeignKey("Endereco")]
        public int EnderecoId { get; set; }
        public virtual Endereco? Endereco { get; set; }
    }
}
