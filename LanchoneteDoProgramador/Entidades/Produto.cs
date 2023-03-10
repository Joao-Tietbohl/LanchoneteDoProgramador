using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteDoProgramador.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal ValorUnitario { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public Produto(int id, string titulo, decimal valor, Fornecedor fornecedor)
        {
            id = Id; Titulo = titulo; ValorUnitario = valor;
            Fornecedor = fornecedor;

        }
    }
}
