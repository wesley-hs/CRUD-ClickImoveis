using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicationClick.Models
{
    [Table("Imovel")]
    public class Imovel
    {
        public DateTime DataCadastro { get; set; }


        public int Id { get; set; }

        public string Nome { get; set; }
        public int Metragem { get; set; }
        public int Vagas { get; set; }
        public int Quartos { get; set; }
        public int Banheiros { get; set; }
        public int Suites { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        public TipoImovel TipoImovel { get; set; }
        public Finalidade Finalidade { get; set; }

        public int UsuarioId { get; set; }             // FK
        public Usuario Usuario { get; set; }           // Navegação
        public decimal Total { get; internal set; }
       
    }
    public enum TipoImovel
    {
        Apartamento,
        Casa       
    }
    public enum Finalidade
    {
        Venda,
        Locacao
    }   
}
