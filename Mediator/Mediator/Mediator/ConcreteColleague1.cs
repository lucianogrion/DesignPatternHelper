using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>

    class ConcreteColleague1 : Colleague
    {
        // Constructor
        public ConcreteColleague1(Mediat mediator): base(mediator)
        {
        }

        public string Send(string message)
        {
           return mediator.Send(message, this);
        }

        public string Notify(string message)
        {
            return "Colleague1 gets message: " + message ;
        }
    }
}
