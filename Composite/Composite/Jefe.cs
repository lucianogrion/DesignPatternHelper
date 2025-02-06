using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Composite
{
    public class Jefe : Empleado
    {
        int indice = 0;
        public Jefe(string _nombre, float _salario)
        {
            base.Add(_nombre, _salario);
            aEmpleados= new ArrayList();
        }
        public override void Add(string _nombre, float _salario)
        {
            this.nombre = _nombre; this.salario = _salario;
            aEmpleados.Insert(indice, this);
            indice++;
        }
        public override void Add(Empleado _empleado)
        {
            aEmpleados.Insert(indice, _empleado);
            indice++;
        }
    }


}
