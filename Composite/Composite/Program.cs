using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Jefe objGerente = new Jefe("Mg. Sc. Alberto Arroyo Viale", 10000);
            Jefe objSubgerente = new Jefe("Ing. Emilia Jesús Raygada Cabezudo", 8000);
            Jefe objJefeSistemas = new Jefe("BeyondNet", 6000);
            objGerente.Add(objSubgerente); objGerente.Add(objJefeSistemas);
            Jefe objJefeDesarrollo = new Jefe("Ing. Pedro Castañeda Vargas",5000);
            Jefe objJefeSoporte = new Jefe("Ing. Renzo Trillo Ramirez", 5000);
            objSubgerente.Add(objJefeDesarrollo);
            objSubgerente.Add(objJefeSoporte);
            Empleado objProgramadorSenior1 = new Jefe("Ing. Carlos Manuel Vasquez Rosas", 3000);
            Empleado objProgramadorSenior2 = new Jefe("Ing. Andres Palomino Rodriguez", 3000);
            Empleado objProgramadorSenior3 = new Jefe("Ing. Luis Dorador Fernandez", 3000);
            Empleado objProgramadorSenior4 = new Jefe("Ing. Carlo Moran Gonzales", 3000);
            objJefeDesarrollo.Add(objProgramadorSenior1);
            objJefeDesarrollo.Add(objProgramadorSenior2);
            objJefeDesarrollo.Add(objProgramadorSenior3);
            objJefeDesarrollo.Add(objProgramadorSenior4);
            Empleado objSoporteSenior1 = new Jefe("Ing. Mario Ojeda Escudero", 3000);
            Empleado objSoporteSenior2 = new Jefe("Ing. Monica Arroyo Raygada", 3000);
            Empleado objSoporteSenior3 = new Jefe("Ing. Miriam Patricia Ocampo Cruz", 3000);
            Empleado objSoporteSenior4 = new Jefe("Ing. Denis Vasquez Ramirez", 3000);
            objJefeSoporte.Add(objSoporteSenior1); objJefeSoporte.Add(objSoporteSenior2);
            objJefeSoporte.Add(objSoporteSenior3); objJefeSoporte.Add(objSoporteSenior3);
            Console.WriteLine("El costo total de salarios en el Dpto. de Sistemas e Informática es: {0}",objGerente.getSalarios());
            Console.ReadLine();

        }
    }
}
