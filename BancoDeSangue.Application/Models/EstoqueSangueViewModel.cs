using BancoDeSangue.Core.Entities;

namespace BancoDeSangue.Application.Models
{
    public class EstoqueSangueViewModel
    {
        public EstoqueSangueViewModel(string tipoSanguineo, string fatorRh, int quantidadeMl)
        {
            TipoSanguineo = tipoSanguineo;
            FatorRh = fatorRh;
            QuantidadeMl = quantidadeMl;
        }

        public string TipoSanguineo { get; private set; }
        public string FatorRh { get; private set; }
        public int QuantidadeMl { get; private set; }

    } 
}
