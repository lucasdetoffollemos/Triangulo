using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloApp
{
    class Triangulo
    {
        private double ladoX;
        private double ladoY;
        private double ladoZ;


        public Triangulo(double ladoX, double ladoY, double ladoZ)
        {
            this.ladoX = ladoX;
            this.ladoY = ladoY;
            this.ladoZ = ladoZ;
        }

        public int VerificaTipoTriangulo()
        {
            int codLado = 0;
            if((ladoX + ladoY > ladoZ) && (ladoY+ ladoZ > ladoX) && (ladoX + ladoZ > ladoY))
            {
                //triangulo equilatero
                if((ladoX == ladoY) && (ladoY == ladoZ))
                {
                    codLado = 1;
                }
                //triangulo isoceles
                else if ((ladoX == ladoY) || (ladoY == ladoZ) || (ladoZ == ladoX))
                {
                    codLado = 2;
                }
                //triangulo escaleno
                else if((ladoX != ladoY) && (ladoY != ladoZ) && (ladoX != ladoZ))
                {
                    codLado = 3;
                } 
            }
            else
            {
                //se o retorno for -1, na program escrever "Triangulo inválido" 
                codLado = -1;
            }

            return codLado;
        }
    }
}
