using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    /// <summary>
    /// Esta clase deberá ser especializada por aquellas que deseen tener
    /// el comportamiento de un Sujeto (objeto observado)
    /// </summary>
    public abstract class Subject
    {
       
            private List<Observer> _observers = new List<Observer>();



            public void Attach(Observer observer)
            {

                _observers.Add(observer);

            }



            public void Detach(Observer observer)
            {

                _observers.Remove(observer);

            }



            public void Notify()
            {

                foreach (Observer o in _observers)
                {

                    o.Update();

                }

            }

        }

    

}
