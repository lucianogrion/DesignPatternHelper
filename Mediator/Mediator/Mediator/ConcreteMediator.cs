using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    class ConcreteMediator : Mediat
    {
        private ConcreteColleague1 _colleague1;
        private ConcreteColleague2 _colleague2;


        public ConcreteColleague1 Colleague1
        {
            set { _colleague1 = value; }
        }

        public ConcreteColleague2 Colleague2
        {
            set { _colleague2 = value; }
        }

        public override string Send(string message, Colleague colleague)
        {
            string rta = "";
            if (colleague == _colleague1)
            {
                message = message + " - He Medidado!!!(el mediador)";
                rta= _colleague2.Notify(message);
            }
            else
            {
               rta= _colleague1.Notify(message);
            }

            return rta;
        }

    }
}
