using BancoDeSangue.Core.Enums;

namespace BancoDeSangue.Core.Entities
{
    public class EstoqueSangue : BaseEntity
    {
        public EstoqueSangue(ETipoSanguineo tipoSanguineo, EFatorRh fatorRh, double quantidadeMl)
        {
            TipoSanguineo = tipoSanguineo;
            FatorRh = fatorRh;
            QuantidadeMl = quantidadeMl;
        }

        public ETipoSanguineo TipoSanguineo { get; private set; }
        public EFatorRh FatorRh { get; private set; }
        public double QuantidadeMl { get; private set; }

        public void AtualizarEstoque(double quantidadeDoada)
        {

            QuantidadeMl += quantidadeDoada;
        }

        public void RemoverDoEstoque(int quantidadeRetirada)
        {
            if (quantidadeRetirada <= 0)
            {
                Console.WriteLine("A quantidade retirada deve ser maior que zero.");
            }

            if (quantidadeRetirada > QuantidadeMl)
            {
                Console.WriteLine("Não há estoque suficiente para a retirada solicitada.");
            }

            QuantidadeMl -= quantidadeRetirada;
        }
    }    
}
