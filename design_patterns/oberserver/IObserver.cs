using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace design_patterns
{
    interface IMyObserver
    {
        void update(IMySubject subject, Object obj);
    }
}
