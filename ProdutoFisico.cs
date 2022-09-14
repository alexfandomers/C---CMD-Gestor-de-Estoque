using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorEstoque
{
    [System.Serializable]
    class ProdutoFisico : Produto, IEstoque
    {
        public float frete;
        private int estoque;

        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;           
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar saida no estoque do produto {nome}");
            Console.WriteLine("Digite a quantidade de para dar baixa: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque -= entrada;
            Console.WriteLine("Saída registrada");
            Console.ReadLine();
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar entrada no estoque do produto {nome}");
            Console.WriteLine("Digite a quantidade de para dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {frete}");
            Console.WriteLine($"Preco: {preco}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine("=====================");
        }

    }
}