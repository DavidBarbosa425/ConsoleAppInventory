using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleAppInventory
{
    class Program
    {
        static List<IEstoque> produtos = new List<IEstoque>();

        enum Menu { Listar = 1, Adicionar, Remover, Entrada, Saida, Sair }



        static void Main(string[] args)
        {


            bool escSair = false;
            while (escSair == false)
            {
                Console.WriteLine("Sistema de estoque");
                Console.WriteLine("==================");
                Console.WriteLine("1 - Listar\n2 - Adicionar\n3 - Remover\n4 - Registrar entrada\n5 - Registrar saida\n6 - Sair");

                String opcStr = Console.ReadLine();
                int opcInt = int.Parse(opcStr);

                if (opcInt > 0 && opcInt < 7)
                {
                    Menu escolha = (Menu)opcInt;

                    switch (escolha)
                    {
                        case Menu.Listar:
                            Console.WriteLine("Listar");
                            break;
                        case Menu.Adicionar:
                            Cadastro();
                            break;
                        case Menu.Remover:
                            Console.WriteLine("Remover");
                            break;
                        case Menu.Entrada:
                            Console.WriteLine("Entrada");
                            break;
                        case Menu.Saida:
                            Console.WriteLine("Saida");
                            break;
                        case Menu.Sair:
                            escSair = true;
                            break;
                    }
                }
                else
                {
                    escSair = true;
                }
                Console.Clear();

            }
        }

        static void Cadastro()
        {
            Console.WriteLine("Cadastro de Produto");
            Console.WriteLine("===================");
            Console.WriteLine("1 - Produto Fisico\n2 - E-Book\n3 - Curso");
            String opcStr = Console.ReadLine();
            int opcInt = int.Parse(opcStr);

            switch (opcInt)
            {
                case 1:
                    CadastrarPFisico();
                    break;
                case 2:
                    CadastrarEbook();
                    break;
                case 3:
                    CadastrarCurso();
                    break;

            }
        }

        static void CadastrarPFisico()
        {
            Console.WriteLine("Cadastrando Produto fisico: ");
            Console.WriteLine("Nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Frete: ");
            float frete = float.Parse(Console.ReadLine());

            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
            produtos.Add(pf);
            Salvar();
        }

        static void CadastrarEbook()
        {
            Console.WriteLine("Cadastrando Ebook: ");
            Console.WriteLine("Nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Autor: ");
            String autor = Console.ReadLine();

            Ebook eb = new Ebook(nome, preco, autor);
            produtos.Add(eb);
            Salvar();
        }

        static void CadastrarCurso()
        {
            Console.WriteLine("Cadastrando Curso: ");
            Console.WriteLine("Nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Autor: ");
            String autor = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());

            Curso cs = new Curso(nome, preco, autor);
            produtos.Add(cs);
            Salvar();
        }

        static void Salvar()
        {
            FileStream stream = new FileStream("produtos.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, produtos);

            stream.Close();
        }
    }
}
