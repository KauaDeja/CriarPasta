﻿using System;
using System.Collections.Generic;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.Codigo = 5;
            p.Nome = "Zed";
            p.Preco = 10f;

            p.Inserir(p);
            p.Remover("Veigar");

            List<Produto> lista = p.Ler();

            foreach(Produto item in lista){
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"R$:{item.Preco} - {item.Nome}");
            }

            //Buscar por Nome através da expressão lambda
            

            

            

            
        }
        
        
    }
}
