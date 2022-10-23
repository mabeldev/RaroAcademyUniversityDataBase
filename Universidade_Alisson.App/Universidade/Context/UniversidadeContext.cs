using Microsoft.EntityFrameworkCore;
using Universidade.Models;
using System.Data.SqlTypes;

namespace Universidade.Context
{
    public class UniversidadeContext : DbContext
    {
        DbSet<Aluno> Alunos { get; set;}
        DbSet<Curso> Cursos { get; set;}
        DbSet<CursoDisciplina> CursoDisciplinas { get; set;}
        DbSet<Departamento> Departamentos { get; set;}
        DbSet<Dependente> Dependentes { get; set;}
        DbSet<Disciplina> Disciplinas { get; set;}
        DbSet<Endereco> Enderecos { get; set;}
        DbSet<Oferta> Ofertas { get; set;}
        DbSet<Professor> Professores { get; set;}
        DbSet<Titulacao> Titulacoes { get; set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer( "Server=44.199.200.211, 3309; Database=universidade_alisson_silva; User=alisson_silva; Password=ugaXvPK8ZWu3JQsw5jcN");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Professor>()
                .HasOne(a => a.Endereco)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder
                .Entity<Aluno>()
                .HasOne(b => b.Endereco)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder
                .Entity<Departamento>()
                .HasOne(c => c.Endereco)
                .WithOne()
                .OnDelete(DeleteBehavior.SetNull);
//----------------------------------------------------------------
            //Aluno tem várias ofertas que tem um Aluno
            modelBuilder
                .Entity<Aluno>()
                .HasMany(d => d.Ofertas)
                .WithOne(o => o.Aluno)
                .OnDelete(DeleteBehavior.SetNull);
            //Professor tem várias ofertas que tem um Professor
            modelBuilder
                .Entity<Professor>()
                .HasMany(d => d.Ofertas)
                .WithOne(o => o.Professor)
                .OnDelete(DeleteBehavior.SetNull);
            //Disciplina tem várias Ofertas que tem uma Disciplina
            modelBuilder
                .Entity<Disciplina>()
                .HasMany(d => d.Ofertas)
                .WithOne(o => o.Disciplina)
                .OnDelete(DeleteBehavior.SetNull);
            // Professor tem vários Dependentes que tem um Professor
            modelBuilder.Entity<Professor>()
                .HasMany(f => f.Dependentes)
                .WithOne(o => o.Professor)
                .OnDelete(DeleteBehavior.SetNull);
//----------------------------------------------------------------
            modelBuilder
                .Entity<Curso>()
                .Property(e => e.Turno)
                .HasConversion<string>();
        }
    }
}