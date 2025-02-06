using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Composite
{
    public interface EmpleadoAbstracto
    {
        void Add(string nombre, float ingreso);
        void Add(Empleado  _empleado);
        IEnumerator getSubordinados();
        IEnumerator getSubordinado(string _nombre);
        float getSalarios();
        float getSalario();
        string getNombre();

    }
}
