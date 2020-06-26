using System;
using System.Collections.Generic;

namespace Aula26Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Carrinho car = new Carrinho();

            Produto p1 = new Produto(2, "Calça", 42.89f);
            Produto p2 = new Produto(3, "Moleton", 53.75f);
            Produto p3 = new Produto(4, "Meia", 18.66f);
            Produto p4 = new Produto(5, "Bermuda", 28.99f);

            car.Adicionar(p1);
            car.Adicionar(p2);
            car.Adicionar(p3);
            car.Adicionar(p4);

            car.Listar();
            car.MostrarTotal();
               
            
            

            
            
        }
    }
}
