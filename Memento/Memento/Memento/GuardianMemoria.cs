using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /// <summary>
    /// Clase que resguarda los datos privados de memento y solo se los da a su due�o
    /// </summary>
    class GuardianMemoria
    {
        private Memento mement;
        public Memento Mement
        {
            get { return mement; }
            set { mement = value; }
        }
    }
}
