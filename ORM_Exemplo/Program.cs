// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

Console.WriteLine("Hello, World!");
public class Genero
{
    [Key]
    public int Id { get; set; }
    public string Descrição { get; set; }

    public ICollection<Filme> Filme { get; set; }
}

public class Filme
{
    [Key]
    public int Id { get; set; }
    public string Titulo { get; set; }
    public int GeneroId { get; set; }

    [ForeignKey("GeneroId")]

    public Genero Genero { get; set; }

}

public class applicationContext : DbContext
{
    public DbSet<Genero> Genero { get; set; }
    public DbSet<Filme> Filme { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlServer(@"Server = .\MSSQLLocalDB; Database=orm;Trusted_Connection = True;");
    }

}
