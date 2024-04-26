using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmpleadoAsalariado empleadoAsalariado1 = new EmpleadoAsalariado("Daniel", 31500, 2700);
            EmpleadoPorHora empleadoPorHora1 = new EmpleadoPorHora("Xavi", 45, 500);


            empleadoAsalariado1.CalcularSalario();
            empleadoPorHora1.CalcularSalario();

        }
    }

    interface InformacionEmpleado
    {
        string Name {get; set;}
    }

    interface CalculadoraSalarial
    {
        void CalcularSalario();
    }

    public abstract class EmpleadoBase : InformacionEmpleado, CalculadoraSalarial
    {
        public string Name {get; set;}
        public abstract void CalcularSalario();
    }
    
    class EmpleadoPorHora : EmpleadoBase
    {
        private string _name;
        private int _salarioPorHora;
        private int _horasTrabajadas;

        public EmpleadoPorHora(string name, int horasTrabajadas, int salario)
        {
            _name = name;
            _horasTrabajadas = horasTrabajadas;
            _salarioPorHora = salario;
        }

        public override void CalcularSalario()
        {
            int salarioTotal = _horasTrabajadas * _salarioPorHora;
            Console.WriteLine("Para el empleado por hora " + this._name + " su sueldo es : " + salarioTotal);
        }
    }

    class EmpleadoAsalariado : EmpleadoBase
    {
        private string _name;
        private int _salario;
        private int _deduccion;

        public EmpleadoAsalariado(string name, int salario, int deduccion)
        {
            _name = name;
            _salario = salario;
            _deduccion = deduccion;
        }

        public override void CalcularSalario()
        {
            int salarioTotal = _salario - _deduccion;
            Console.WriteLine("Para el empleado Asalariado " + this._name + " su sueldo es : " + salarioTotal);
        }
    }


}


