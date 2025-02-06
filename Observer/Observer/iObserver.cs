using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    /// <summary>
    /// Esta interfaz debe ser implementada por cualquiera que quiera
    /// observar un Subject.
    /// </summary>
    public interface IObserver
    {
        void Update(Subject sender);
    }
}
