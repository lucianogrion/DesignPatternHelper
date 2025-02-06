using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    /// <summary>

    /// A 'ConcreteColleague' class

    /// </summary>

    class ConcreteColleague2 : Colleague
    {

        // Constructor

        public ConcreteColleague2(Mediat mediator)

            : base(mediator)
        {

        }



        public string Send(string message)
        {

            return mediator.Send(message, this);

        }



        public string Notify(string message)
        {
            return "Colleague2 gets message: " + message;
        }

    }
}
