namespace BancoDeSangue.Application.Models
{
    public class UpdateDoadorInputModel
    {
        public int IdDoador { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }
        public string Genero { get; set; }
        public double Peso { get; set; }
    }
}

