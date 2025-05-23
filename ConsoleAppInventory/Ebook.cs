﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInventory
{
    [System.Serializable]

    class Ebook : Produto, IEstoque
    {
        public String autor;
        private int vendas;

        public Ebook(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Não é m=necessário dar entrada neste produto.");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar vendas no E-book {nome}");
            Console.WriteLine($"Digite a quantidade de vendas que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            vendas += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vendas: {vendas}");
            Console.WriteLine("=========================");
        }
    }
}
