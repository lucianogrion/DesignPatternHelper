using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    /// <summary>
    /// The 'Colleague' abstract class
    /// </summary>
    abstract class Colleague
    {
        protected Mediat mediator;

        // Constructor
        public Colleague(Mediat mediator)
        {
            this.mediator = mediator;
        }

    }
}
