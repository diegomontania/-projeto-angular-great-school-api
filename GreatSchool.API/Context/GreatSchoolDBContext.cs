using GreatSchool.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GreatSchool.API.Context
{
    //continuar aqui
    //https://www.youtube.com/watch?v=OtLjyRoAkDA&list=PLP8G5dOGVPmCelJpg8qWzO8zMfTxf0K9k&index=6

    //fluent api o que pode ser feito, definir nome de tabelas, nome de chaves primarias,
    //ignorar campos na classe para serem ignorados na criacao da tabela, relacionamentos
    //https://www.youtube.com/watch?v=7M501P-23Jg

    //relacionamentos 1-1 e 1-N -- MUITO BOM! TALVEZ DAR CONTINUIEDADE POR AQUI!
    //https://www.youtube.com/watch?v=eHT6G912po0

    //propriedades de navegacao
    //https://www.youtube.com/watch?v=rXP632YwwfQ 1-N
    //https://www.youtube.com/watch?v=Qh2hgIc90y0 N-N

    public class GreatSchoolDBContext : DbContext
    {
        //toda vez que for criado uma propriedade ou objeto com 'virtual' é utilizado o 'LazyLoading' para carrega-los
        //https://stackoverflow.com/a/15247765/13156642
        public virtual DbSet<Aluno> Alunos { get; set; }

        public virtual DbSet<Professor> Professores { get; set; }

        public virtual DbSet<Turma> Turmas { get; set; }

        public virtual DbSet<Matricula> Matriculas { get; set; }

        public GreatSchoolDBContext() { }

        public GreatSchoolDBContext(DbContextOptions<GreatSchoolDBContext> options) : base(options) { }

        //cria os relacionamentos entre os modelos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //um aluno tem uma matricula e apenas uma matricula
            modelBuilder.Entity<Aluno>()
                .HasOne(m => m.Matricula)
                .WithOne();

            //uma turma tem um professor e apenas um professor
            modelBuilder.Entity<Turma>()
                .HasOne(p => p.Professor)
                .WithOne();

            //uma turma tem N alunos e os alunos possuem apenas uma turma
            modelBuilder.Entity<Turma>()
                .HasMany(a => a.Alunos)
                .WithOne();
        }
    }
}
