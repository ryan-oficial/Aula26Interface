using System;
using System.Collections.Generic;

namespace Aula26Interface
{
    public class Carrinho : ICarrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();
        
        
        public void Alterar(int _codigo, Produto produto)
        {
            carrinho.Find(x => x.Codigo  == _codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo  == _codigo).Preco = produto.Preco;
        }

        public void Adicionar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Listar()
        {
            foreach(Produto item in carrinho){
                System.Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }
        }
        public void MostrarTotal(){
            foreach(Produto p in carrinho){
                ValorTotal += p.Preco;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"Valor Total do itens: R$ {ValorTotal}");
            Console.ResetColor();
        }
    }
}