using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroEndereco
{
    public class Endereco
    {
        public Endereco(string? nome,
            string? cep, string? logradouro,
            string? numero, string? complemento,
            string? bairro, string? cidade, string? uf,
            bool semNumero)
        {
            Nome = nome;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cidade = cidade;
            Bairro = bairro;
            Uf = uf;
            SemNumero = semNumero;
        }
        public Endereco() { }

        public static List<Endereco>ListaEnderecos = new List<Endereco>();

        public string? Nome { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public bool SemNumero { get; set; }

    }
}
