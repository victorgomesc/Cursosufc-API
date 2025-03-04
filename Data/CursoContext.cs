using Microsoft.EntityFrameworkCore;

using Cursosufc.Models;

namespace Cursosufc.Data;

public class CursoContext: DbContext {
     public DbSet<CursoModel> Curso { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=curso.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}