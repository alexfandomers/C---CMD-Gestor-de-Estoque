using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorEstoque
{
    [System.Serializable]
    class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome, float preco, string autor)
        {
             this.nome = nome;
             this.autor = autor;
             this.preco = preco;             
        }
         public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar vendas no ebook {nome}");
            Console.WriteLine("Digite a quantidade de vendas para dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            vendas += entrada;
            Console.WriteLine("Saída registrada");
            Console.ReadLine();
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Produto digital sem entrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preco: {preco}");
            Console.WriteLine($"Vendas registradas: {vendas}");
            Console.WriteLine("=====================");
        }        
        
    }
}