using Cursosufc.Data;
using Cursosufc.Models;
using Microsoft.EntityFrameworkCore;

namespace Cursosufc.Routes;

public static class CursoRoute {
    public static void CursoRoutes(this WebApplication app)
    {
        var route = app.MapGroup("curso");

        route.MapPost("", async (CursoRequest req, CursoContext context ) => 
        {
        var curso = new CursoModel(req.nomeCurso, req.descricao, req.duracao, req.modalidade);
        await context.AddAsync(curso);
        await context.SaveChangesAsync();
    
        return Results.Created($"/curso/{curso.Id}", curso); 
        });

        route.MapGet("", async (CursoContext context) => 
        {
            var curso = await context.Curso.ToListAsync();
            return Results.Ok(curso);
        });

        route.MapPut("{id:guid}", async (Guid id, CursoRequest req, CursoContext context) => 
        {
            var curso = await context.Curso.FirstOrDefaultAsync(x => x.Id == id);

            if (curso == null){
                return Results.NotFound();
            }

            curso.ChangeNomeCurso(req.nomeCurso);
            await context.SaveChangesAsync(); 

            curso.ChangeDescricao(req.descricao);
            await context.SaveChangesAsync();

            curso.ChangeDuracao(req.duracao);
            await context.SaveChangesAsync();

            curso.ChangeModalidade(req.modalidade);
            await context.SaveChangesAsync();

            return Results.Ok(curso);
        });

        route.MapDelete("{id:guid}", async (Guid id, CursoContext context) => 
        {
            var curso = await context.Curso.FirstOrDefaultAsync(x => x.Id == id);

            if (curso == null){
                return Results.NotFound();
            }

            context.Curso.Remove(curso);
            await context.SaveChangesAsync();

            return Results.NoContent();
        });

    }
}