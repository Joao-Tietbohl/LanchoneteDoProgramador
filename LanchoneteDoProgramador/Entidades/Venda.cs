using LanchoneteDoProgramador.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteDoProgramador.Entidades
{
    public class Venda
    {
        public int Id { get; set; }
        public List<Produto> Produtos { get; set; }
        public FormaDePagamento FormaDePagamento { get; set; }
        public string CpfCliente { get; set; }

        public void AdicionarProduto(Produto produto, int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
            {
                Produtos.Add(produto);
            }
        }

        public void RemoverProduto(Produto produto, int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
            {
                Produtos.Remove(produto);
            }
        }

        public decimal CalcularValorTotal()
        {
            decimal valorTotal = 0;
            foreach (var produto in Produtos)
            {
                valorTotal += produto.ValorUnitario;
            }
            return valorTotal;
        }
    }

    public enum FormaDePagamento
    {
        Dinheiro,
        CartaoDeCredito,
        CartaoDeDebito,
        TransferenciaBancaria,
        Pix
    }
}
