using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    interface Subject
    {
        void registerObserver(Observer o);
        void removeObserver(Observer o);
        void notifyObservers();
    }
}
