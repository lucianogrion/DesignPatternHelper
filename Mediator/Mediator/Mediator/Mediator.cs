using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
     abstract class Mediat
    {
        public abstract string Send(string message,Colleague colleague);

    }
}
