using System;

namespace Estructura
{
    internal class program
    {
        static void Main(string[] args)
        {
            Salario miEmpleado1 = new(1001, "Hamel", 1900, 19);

            miEmpleado1.GetDatosEmpleados();
            Console.WriteLine("Salario: " + miEmpleado1.salario);
            Console.WriteLine("Comision: " + miEmpleado1.comision);
            

            miEmpleado1.AumentoSalario(100);
            Console.WriteLine();
            miEmpleado1.GetDatosEmpleados();
            Console.WriteLine("Despues del aumento");
            Console.WriteLine($"Salario: {miEmpleado1.salario}");
            Console.WriteLine($"Comision: {miEmpleado1.comision}");
        }
    }
    struct Salario
    {
        private int idEmpleado;
        private string nombre;
        public double salario;
        public double comision;

        public Salario(int idEmpleado, string nombre, double salario, double comision)
        {
            this.idEmpleado = idEmpleado;
            this.nombre = nombre;
            this.salario = salario;
            this.comision = comision;
        }

        public void AumentoSalario(double aumento)
        {
            this.salario = this.salario + aumento;
            this.comision = this.comision + aumento;            
        }

        public void GetDatosEmpleados()
        {
            Console.WriteLine($"Id: {this.idEmpleado}");
            Console.WriteLine($"Nombre: {this.nombre}");
        }

    }
}
