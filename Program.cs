using System;
using System.Collections.Generic;

namespace Cadastro_Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            int opcao = 0;
            do
            {
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Atualizar");
                Console.WriteLine("4 - Deletar");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    // Cadastrar
                    case 1:
                        Console.WriteLine("Digite o nome do produto: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o preço do produto: ");
                        float preco = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a ID do produto: ");
                        int id = int.Parse(Console.ReadLine());
                        produtos.Add(new Produto(nome, preco, id));
                        break;
                    // Listar
                    case 2:
                        foreach (Produto p in produtos)
                        {
                            Console.WriteLine("Nome do produto: " + p.Nome + "\nPreço: " + p.Preco + "\nId: " + p.Id);
                        }
                        break;
                    // Atualizar
                    case 3:
                        Console.WriteLine("Digite a Id do produto: ");
                        int idAtualizar = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome do produto");
                        string nomeAtualizar = Console.ReadLine();
                        Console.WriteLine("Digite o preço do produto");
                        float precoAtualizar = float.Parse(Console.ReadLine());
                        foreach (Produto p in produtos)
                        {
                            if (p.Id == idAtualizar)
                            {
                                p.Nome = nomeAtualizar;
                                p.Preco = precoAtualizar;
                            }
                        }
                        break;
                    // Deletar
                    case 4:
                        Console.WriteLine("Digite a Id do produto: ");
                        string nomeDeletar = Console.ReadLine();
                        List<Produto> produtosParaDeletar = new List<Produto>();
                        foreach (Produto p in produtos)
                        {
                            if (p.Nome == nomeDeletar)
                            {
                                produtosParaDeletar.Add(p);
                            }
                        }
                        foreach (Produto p in produtosParaDeletar)
                        {
                            produtos.Remove(p);
                        }
                        break;
                    default:
                        break;
                }
            } while (opcao != 0);
        }
    }

    class Produto
    {
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Id { get; set; }

        public Produto(string nome, float preco, int id)
        {
            Nome = nome;
            Preco = preco;
            Id = id;
        }
    }
}
