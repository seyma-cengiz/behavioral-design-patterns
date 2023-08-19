using BehavioralPattern.Observer.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern.Observer.Subjects
{
    //Publisher / Subject
    public interface INotifier
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
