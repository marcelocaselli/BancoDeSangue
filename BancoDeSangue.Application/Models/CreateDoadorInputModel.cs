namespace BancoDeSangue.Application;

public class CreateDoadorInputModel
{
    public string NomeCompleto { get; set; }
    public string Email { get;  set; }
    public DateTime DataAniversario { get;  set; }
    public string Genero { get;  set; }
    public double Peso { get;  set; }
    public string TipoSanguineo { get;  set; }
    public string FatorRh { get;  set; }
}

