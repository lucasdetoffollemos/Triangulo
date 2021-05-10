using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloApp
{
    class TelaTriangulo
    {
        public string ObterOpcao()
        {
            Console.WriteLine("Digite 1 para verficar o tipo do triangulo: ");
            Console.WriteLine("Digite S para sair");

            string opcao = Console.ReadLine();
            Console.Clear();
            return opcao;
        }

        public void VerficaTriangulo()
        {
            double lado1, lado2, lado3;

            Console.WriteLine("Digite o valor de um lado do triângulo: ");
            lado1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o valor de outro lado do triângulo: ");
            lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o valor do último lado do triângulo: ");
            lado3 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Triangulo triangulo = new Triangulo(lado1, lado2, lado3);
            int codigoTriangulo = triangulo.VerificaTipoTriangulo();


            if (codigoTriangulo == 1)
            {
                Console.WriteLine("Triângulo Eqüilátero.");
                Console.ReadLine();
            }
            else if (codigoTriangulo == 2)
            {
                Console.WriteLine("Triângulo Isóscele.");
                Console.ReadLine();
            }
            else if (codigoTriangulo == 3)
            {
                Console.WriteLine("Triângulo Escaleno.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Triangulo Inválido.");
                Console.ReadLine();
            }
        }
    }
}
