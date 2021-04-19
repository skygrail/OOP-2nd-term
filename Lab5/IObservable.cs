using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    interface IObservable
    {
        void AddObserver(IObserver fl);
        void RemoveObserver(IObserver fl);
        void NotifyObservers();
    }

    interface IObserver
    {
        void Update(object obj);
    }
}
