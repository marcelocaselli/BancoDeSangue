namespace BancoDeSangue.Core.Entities
{
    public class Endereco : BaseEntity
    {
        public Endereco(string rua, string cidade, string estado, string cep)
            :base()
        {
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }

        public int IdEndereco { get; private set; }
        public string Rua { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Cep { get; private set; }
        //public Doador Doador { get; set; }
    }
}

