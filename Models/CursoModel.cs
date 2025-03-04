namespace Cursosufc.Models;


public class CursoModel{
    public CursoModel(string nomeCurso, string descricao, int duracao, string modalidade){
        NomeCurso = nomeCurso;
        Descricao = descricao;
        Duracao = duracao;
        Modalidade = modalidade;
        Id =  Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string NomeCurso { get; set; }
    public string Descricao { get; set; }
    public int Duracao { get; set; }
    public string Modalidade { get; set; }

    public void ChangeNomeCurso(string nomeCurso){
        NomeCurso = nomeCurso;
    }

    public void ChangeDescricao(string descricao){
        Descricao = descricao;
    }

    public void ChangeDuracao(int duracao){
        Duracao = duracao;
    }

    public void ChangeModalidade(string modalidade){
        Modalidade = modalidade;
    }
}