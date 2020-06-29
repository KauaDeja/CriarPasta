using System.IO;

namespace Aula27_28_29_30
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string DataBase = @"C:\Users\Usuario\Documents\Projetos\Aula 27_28_29_30\DataBase";
        private const string PATH = "Database/Produto.csv";

        public void Diretorio(){ 
            if(!Directory.Exists(DataBase)){
                
                Directory.CreateDirectory(DataBase);
            }
        } 

        
        
        public Produto(){
            //Criar arquivo caso n exista
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }
      

        
        public void Inserir(Produto p){
            var linha = new string[]{ p.PeprararLinhaCSV(p) };
            File.AppendAllLines(PATH, linha);
        }

        private string PeprararLinhaCSV(Produto produto){
            return $"codigo={produto.Codigo};nome={produto.Nome};preco={produto.Preco}";
        }

        
    }
}