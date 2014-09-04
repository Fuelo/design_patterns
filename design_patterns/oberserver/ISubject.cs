using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace design_patterns
{
    interface IMySubject
    {
        void addObserver(IMyObserver observer);
        void removeObserver(IMyObserver observer);
        void notifyObservers(Object state);
        Object getState();
    }
}
