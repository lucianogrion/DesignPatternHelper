using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /// <summary>
    /// Clase que posee atributos que deberan ser guardados para una posible restauracion
    /// </summary>
    class ProspectoVentas
    {
        private string nombre;
        private string telefono;
        private double gasto;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                Console.WriteLine("Nombre: " + nombre);
            }
        }
        public string Telefono
        {
            get { return telefono; }
            set
            {
                telefono = value;
                Console.WriteLine("Telefono: " + telefono);
            }
        }
        public double Gasto
        {
            get { return gasto; }
            set
            {
                gasto = value;
                Console.WriteLine("Gasto: " + gasto);
            }
        }
        public Memento GuardarMemento()
        {
            Console.WriteLine("Guardando estado\n");
            return new Memento(nombre, telefono, gasto);
        }
        public void RetornarEstado(Memento memento)
        {
            Console.WriteLine("Restaurando estado\n");
            Nombre = memento.Nombre;
            Telefono = memento.Telefono;
            Gasto = memento.Gasto;
        }
    }

    
}
