using BehavioralPattern.Observer.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern.Observer.Subjects
{
    public class ProductNotifier : INotifier
    {
        public Product _product;
        private readonly List<IObserver> _observerList;
        public ProductNotifier(Product product)
        {
            _product = product;
            _observerList = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _observerList.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observerList.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observerList)
            {
                observer.Notify(_product);
            }
        }

        public void UpdateStock()
        {
            _product.Stock++;
            Notify();
        }
    }
}
