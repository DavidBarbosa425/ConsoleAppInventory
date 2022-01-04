using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInventory
{
    [System.Serializable]

    class ProdutoFisico : Produto, IEstoque
    {
        public float frete;
        public int estoque;

        public ProdutoFisico(String nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete; 
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar entrada no estoque do produto {nome}");
            Console.WriteLine($"Digite a quantidade que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();

        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar saida no estoque do produto {nome}");
            Console.WriteLine($"Digite a quantidade que você quer dar baixa: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque -= entrada;
            Console.WriteLine("Saída registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine("=========================");
        }
    }
}
