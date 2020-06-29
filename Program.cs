using System;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.Codigo = 5;
            p.Nome = "Riven";
            p.Preco = 58.59f;

            p.Inserir(p);

            

            
        }
        
        
    }
}
