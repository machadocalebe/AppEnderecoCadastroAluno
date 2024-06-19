using AppEnderecoCadastroAluno.Models;
using Microsoft.EntityFrameworkCore;

namespace AppEnderecoCadastroAluno.DAL
{
    public class INFNETContexto : DbContext
    {
        public INFNETContexto(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>()
                .HasOne(a => a.Endereco)
                .WithOne(e => e.Aluno)
                .HasForeignKey<Aluno>(a => a.EnderecoId);
        }
    
        
    }
}
