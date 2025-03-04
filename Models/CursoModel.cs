namespace Cursosufc.Models;


public class CursoModel{
    public CursoModel(string nomeCurso, string descricao, string duracao, string modalidade){
        NomeCurso = nomeCurso;
        Descricao = descricao;
        Duracao = duracao;
        Modalidade = modalidade;
        Id =  Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string NomeCurso { get; set; }
    public string Descricao { get; set; }
    public string Duracao { get; set; }
    public string Modalidade { get; set; }
}