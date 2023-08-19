using BehavioralPattern.Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern.Observer.Observers
{
    //Subscriber / Observer
    public interface IObserver
    {
        void Attach(INotifier subject);
        void Detach(INotifier subject);
        void Notify(Product product);
    }
}
