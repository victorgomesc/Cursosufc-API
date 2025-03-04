namespace Cursosufc.Models;


public class CursoModel{
    public CursoModel(string nomeCurso, string descricao, string duracao, string modalidade){
        NomeCurso = nomeCurso;
        Descricao = descricao;
        Duracao = duracao;
        Modalidade = modalidade;
        Id =  Guid.NewGuid();
    }
}