namespace BancoDeSangue.Application.Models
{
    public class CreateEnderecoInputModel
    {
        public int IdDoador { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}
