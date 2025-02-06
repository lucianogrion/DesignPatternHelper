using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /// <summary>
    ///  Clase memento, la guarda los datos propiamente dichos
    /// </summary>
    class Memento
    {
        private string nombre;
        private string telefono;
        private double gasto;

        public Memento(string nom, string tel, double gast)
        {
            nombre = nom;
            telefono = tel;
            gasto = gast;
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;

            }
        }
        public string Telefono
        {
            get { return telefono; }
            set
            {
                telefono = value;

            }
        }
        public double Gasto
        {
            get { return gasto; }
            set
            {
                gasto = value;
            }
        }
    }
}
