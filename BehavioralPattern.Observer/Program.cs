// See https://aka.ms/new-console-template for more information

using BehavioralPattern.Observer;
using BehavioralPattern.Observer.Observers;
using BehavioralPattern.Observer.Subjects;

var product = new Product
{
    Id = 1,
    Name = "Test Product 1",
    Price = 1000
};
var productSubject = new ProductNotifier(product);

var customer1 = new Customer("Test Customer 1");
var customer2 = new Customer("Test Customer 2");
customer1.Attach(productSubject);
customer2.Attach(productSubject);

productSubject.UpdateStock();

customer2.Detach(productSubject);

productSubject.UpdateStock();

Console.ReadKey();

