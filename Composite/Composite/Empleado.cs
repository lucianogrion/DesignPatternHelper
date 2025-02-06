using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Composite
{
    public class Empleado : EmpleadoAbstracto
    {
        protected ArrayList aEmpleados;
        protected string nombre;
        protected float salario;
        int indice = 0;
        public Empleado() { }
        public Empleado(string _nombre, float _salario)
        {
            this.nombre = _nombre; this.salario = _salario;
            aEmpleados = new ArrayList();
        }
        public string getNombre() { return this.nombre; }
        public float getSalario() { return this.salario; }
        public virtual void Add(string _nombre, float _salario)
        {
            if (aEmpleados == null)
            {
                aEmpleados = new ArrayList();
            }
            this.nombre = _nombre; this.salario = _salario;
            aEmpleados.Insert(indice, this);
            indice++;
        }

        public virtual void Add(Empleado   _empleado) { }

        //Interface común entre los objetos
        public float getSalarios()
        {
            float total = 0;
            EmpleadoAbstracto objAbstracto;
            IEnumerator iterador;
            total = getSalario();
            try
            {
                iterador = aEmpleados.GetEnumerator();
                while (iterador.MoveNext())
                {
                    objAbstracto = ((Empleado)(iterador.Current));
                    total += objAbstracto.getSalarios();
                }
            }
            catch (Exception ex)
            { throw ex; }
            return total;
        }

        public IEnumerator getSubordinados()
        {
            foreach (Empleado obj in aEmpleados)
                yield return obj;
        }

        public void Quitar(Empleado _empleado) { }

        public IEnumerator getSubordinado(string _nombre)
        {
            foreach (Empleado obj in aEmpleados)
            {
                if (obj.nombre == _nombre)
                    yield return obj;
            }
        }

        public IEnumerator getEnumerator()
        {
            foreach (Empleado obj in aEmpleados)
            {
                yield return obj;
            }
        }
    }


}
