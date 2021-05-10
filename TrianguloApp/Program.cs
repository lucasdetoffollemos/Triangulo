using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TelaTriangulo telaTriangulo = new TelaTriangulo();

            while (true)
            {
                string opcao = telaTriangulo.ObterOpcao();

                //verficando se opcao é existente 
                if(opcao != "1" && opcao != "s" && opcao != "S")
                {
                    Console.WriteLine("Opcao inválida, tente novamente.");
                    
                    Console.Clear();
                    continue;
                }
                
                if(opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (opcao == "1") {

                    telaTriangulo.VerficaTriangulo();
                }
            }
           
            
        }
    }
}
