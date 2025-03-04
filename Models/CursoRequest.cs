namespace Cursosufc.Models;

public record CursoRequest(
    string nomeCurso,
    string descricao,
    int duracao,
    string modalidade
);