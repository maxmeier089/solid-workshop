using System;
using System.Collections.Generic;
using System.Text;

namespace Solution2
{
    public interface Subject
    {
        public void Attach(Observer observer);
        public void Detach(Observer observer);
        public void NotifyAttachedObservers();

    }
}
