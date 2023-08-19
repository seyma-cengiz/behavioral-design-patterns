using BehavioralPattern.Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern.Observer.Observers
{
    public class Customer : IObserver
    {
        public string Name { get; set; }
        public Customer(string name)
        {
            Name = name;
        }

        public void Notify(Product product)
        {
            Console.WriteLine($"Dear {Name}; Stock of the {product.Name} product that you saved is updated.");
        }

        public void Attach(INotifier subject)
        {
            Console.WriteLine($"{Name} added to notify list.");
            subject.Attach(this);
        }

        public void Detach(INotifier subject)
        {
            Console.WriteLine($"{Name} removed from notify list.");
            subject.Detach(this);
        }
    }
}
