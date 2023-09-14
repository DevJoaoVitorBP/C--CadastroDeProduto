using System;
using System.Collections.Generic;
using System.Linq; 

namespace Cadastro_Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista de produtos
            List<Produto> produtos = new List<Produto>();
            int opcao = 0;
            
            do
            {
                // Menu
                Console.WriteLine("\n1 - Cadastrar");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Atualizar");
                Console.WriteLine("4 - Deletar");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Digite uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    // Cadastrar
                    case 1:
                        Console.WriteLine("\nDigite o nome do produto: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o preço do produto: ");
                        float preco = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a ID do produto: ");
                        int id = int.Parse(Console.ReadLine());
                        produtos.Add(new Produto(nome, preco, id)); // Adiciona um novo produto à lista
                        break;
                    // Listar
                    case 2:
                        if (produtos.Count > 0)
                        {
                            Console.WriteLine("\nLista de Produtos:");
                            foreach (Produto p in produtos)
                            {
                                Console.WriteLine($"Nome do produto: {p.Nome}\nPreço: R${p.Preco}\nId: {p.Id}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhum produto cadastrado.");
                        }
                        break;
                    // Atualizar utilizando a referência do Id
                    case 3:
                        Console.WriteLine("Digite a Id do produto: ");
                        int idAtualizar = int.Parse(Console.ReadLine());
                        Produto produtoParaAtualizar = produtos.FirstOrDefault(p => p.Id == idAtualizar);
                        
                        if (produtoParaAtualizar != null)
                        {
                            Console.WriteLine("Digite o novo nome do produto: ");
                            produtoParaAtualizar.Nome = Console.ReadLine();
                            Console.WriteLine("Digite o novo preço do produto: ");
                            produtoParaAtualizar.Preco = float.Parse(Console.ReadLine());
                            Console.WriteLine("Produto atualizado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado.");
                        }
                        break;
                    // Deletar
                    case 4:
                        Console.WriteLine("Digite a Id do produto: ");
                        int idDeletar = int.Parse(Console.ReadLine());
                        Produto produtoParaDeletar = produtos.FirstOrDefault(p => p.Id == idDeletar);
                        
                        if (produtoParaDeletar != null)
                        {
                            produtos.Remove(produtoParaDeletar); // Remove o produto da lista
                            Console.WriteLine("\nProduto deletado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("\nProduto não encontrado.");
                        }
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!"); // Caso o usuário digite uma opção inválida
                        break;
                }
            } while (opcao != 0); // Continua o loop até que o usuário escolha a opção 0 para sair
        }
    }

    // Classe Produto com os atributos Nome, Preço e Id
    class Produto
    {
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Id { get; set; }

        // Construtor da classe Produto
        public Produto(string nome, float preco, int id)
        {
            Nome = nome;
            Preco = preco;
            Id = id;
        }
    }
}
