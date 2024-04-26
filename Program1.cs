using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string entrada = Console.ReadLine();
            string entrada2 = Console.ReadLine();

            int numero1 ;
            int numero2 ;

            int.TryParse(entrada, out numero1);
            int.TryParse(entrada2, out numero2);
           
            FuncionSumar suma = new FuncionSumar(numero1, numero2);
            FuncionRestar resta = new FuncionRestar(numero1, numero2);
            FuncionMultiplicar multi = new FuncionMultiplicar(numero1, numero2);
            FuncionDividir dividir = new FuncionDividir(numero1, numero2);

            Console.WriteLine("La Suma es: " + suma.Sumar(numero1, numero2));
            Console.WriteLine("La Resta es: " + resta.Resta(numero1, numero2));
            Console.WriteLine("La Multiplicación es: " + multi.Multiplicar(numero1, numero2));
            Console.WriteLine("La Division es: " + dividir.Dividir(numero1, numero2) );
            
        }
    }

    class FuncionSumar
    {
        private int numero1;
        private int numero2;

        public FuncionSumar(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public int Sumar(int numero1, int numero2)
        {
            int result = numero1 + numero2;
            return result;
        }
    }

    class FuncionRestar
    {
        private int numero1;
        private int numero2;

        public FuncionRestar(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public int Resta(int numero1, int numero2)
        {
            int result = numero1 - numero2;
            return result;
        }
    }

    class FuncionMultiplicar
    {
        private int numero1;
        private int numero2;

        public FuncionMultiplicar(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            int result = numero1 * numero2;
            return result;
        }
    }

    class FuncionDividir
    {
        private int numero1;
        private int numero2;

        public FuncionDividir(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public double Dividir(int numero1, int numero2)
        {
            double result = numero1 / numero2;
            return result;
        }
    }
}
