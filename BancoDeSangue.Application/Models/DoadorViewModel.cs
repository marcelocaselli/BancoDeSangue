using BancoDeSangue.Core.Entities;
using BancoDeSangue.Core.Enums;

namespace BancoDeSangue.Application.Models
{
    public class DoadorViewModel
    {
        public DoadorViewModel(int id, string nomeCompleto, string email, 
            DateTime dataAniversario, EGenero genero, double peso, ETipoSanguineo tipoSanguineo, 
            EFatorRh fatorRh, Endereco endereco, List<Doacao> doacoes)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            Email = email;
            DataAniversario = dataAniversario;
            Genero = genero;
            Peso = peso;
            TipoSanguineo = tipoSanguineo;
            FatorRh = fatorRh;
            Endereco = endereco;
            Doacoes = doacoes;
        }

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public string Email { get; private set; }
        public DateTime DataAniversario { get; private set; }
        public EGenero Genero { get; private set; }
        public double Peso { get; private set; }
        public ETipoSanguineo TipoSanguineo { get; private set; }
        public EFatorRh FatorRh { get; private set; }
        public Endereco Endereco { get; private set; }
        public List<Doacao> Doacoes { get; set; }
    }
}

