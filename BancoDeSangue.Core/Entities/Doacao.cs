namespace BancoDeSangue.Core.Entities
{
    public class Doacao : BaseEntity
    {
        public Doacao(int idDoador, double quantidadeMl)
        {
            IdDoador = idDoador;            
            QuantidadeMl = quantidadeMl;
            DataDoacao = DateTime.Now;
        }

        public int IdDoador { get; private set; }
        public DateTime DataDoacao { get; private set; }
        public double QuantidadeMl { get; private set; }
        public Doador Doador { get; private set; }

        public void Update(int quantidadeMl, int IdDoador)
        {
            IdDoador = IdDoador;
            QuantidadeMl = quantidadeMl;
        }
    }
}
