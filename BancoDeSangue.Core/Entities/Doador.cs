using BancoDeSangue.Core.Enums;
using System.Net;

namespace BancoDeSangue.Core.Entities
{
    public class Doador : BaseEntity
    {
        public Doador(string nome, string email, DateTime dataAniversario, EGenero genero, 
            double peso, ETipoSanguineo tipoSanguineo, EFatorRh fatorRh, Endereco endereco)
        {
            NomeCompleto = nome;
            Email = email;
            DataAniversario = dataAniversario;
            Genero = genero;
            Peso = peso;
            TipoSanguineo = tipoSanguineo;
            FatorRh = fatorRh;
            Endereco = endereco;

            //Doacoes = [];
            DoadorStatus = EDoadorStatus.Active;
        }

        public string NomeCompleto { get; private set; }
        public string Email { get; private set; }
        public DateTime DataAniversario { get; private set; }
        public EGenero Genero { get; private set; }
        public double Peso { get; private set; }
        public ETipoSanguineo TipoSanguineo { get; private set; }
        public EFatorRh FatorRh { get; private set; }
        public List<Doacao> Doacoes { get; private set; } = new List<Doacao>();
        public Endereco Endereco { get; private set; }
        public EDoadorStatus DoadorStatus { get; private set; }

        public void Update(string nomecompleto, string email, DateTime dataaniversario, EGenero genero, 
            double peso, ETipoSanguineo tiposanguineo, EFatorRh fatorrh, Endereco endereco)
        {
            NomeCompleto = nomecompleto;
            Email = email;
            DataAniversario = dataaniversario;
            Genero = genero;
            Peso = peso;
            TipoSanguineo = tiposanguineo;
            FatorRh = fatorrh;
            Endereco = endereco;
        }
    }
}
