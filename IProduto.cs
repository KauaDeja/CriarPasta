using System.Collections.Generic;

namespace Aula27_28_29_30
{
    public interface IProduto

    {
        /// <summary>
        /// Interface serve para amarrar mais ainda nossa aplicação.
        /// </summary>
        /// <param name="prd">Métodos</param>
         void Cadastrar(Produto prd);

         void Remover(string _termo);
         void Ler();
         void Alterar(Produto _produtoAlterado);
         void Reescrever(List<string> lines);
         List<Produto> Filtrar(string _nome);
         string Separar(string _coluna);
         string PrepararLinha(Produto p);

    }
}