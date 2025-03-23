using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOps
{
    class Tester
    {
        internal static List<Person> GeneratePersonData()
        {
            List<Person> data = new List<Person>();
            data.Add(new Person { FirstName = "Michael", LastName = "Huber", Age = 40, City = "Graz" });
            data.Add(new Person { FirstName = "Jasmin", LastName = "Wolke", Age = 42, City = "Wien" });
            data.Add(new Person { FirstName = "Benjamin", LastName = "Strauss", Age = 43, City = "Salzburg" });
            data.Add(new Person { FirstName = "Susanna", LastName = "Herbst", Age = 62, City = "Tirol" });
            data.Add(new Person { FirstName = "Wolfgang", LastName = "Trummer", Age = 46, City = "Graz" });
            data.Add(new Person { FirstName = "Marko", LastName = "Ball", Age = 15, City = "Wien" });
            data.Add(new Person { FirstName = "Matheo", LastName = "Lustig", Age = 13, City = "Hollabrunn" });
            data.Add(new Person { FirstName = "Annika", LastName = "Sommer", Age = 18, City = "Kärnten" });
            data.Add(new Person { FirstName = "Manual", LastName = "Sacher", Age = 18, City = "Steiermark" });
            data.Add(new Person { FirstName = "Ophone", LastName = "Sax", Age = 31, City = "New York" });
            data.Add(new Person { FirstName = "Pet", LastName = "Trom", Age = 18, City = "New York" });
            return data;
        }

        internal static List<Customer> GenerateCustomerData()
        {
            List<Customer> data = new List<Customer>();
            data.Add(new Customer { CustomerID = 0, Name = "Customer1" });
            data.Add(new Customer { CustomerID = 1, Name = "Customer2" });
            data.Add(new Customer { CustomerID = 2, Name = "Customer3" });
            data.Add(new Customer { CustomerID = 3, Name = "Customer4" });
            return data;
        }

        internal static List<Order> GenerateOrderData()
        {
            List<Order> data = new List<Order>();
            data.Add(new Order { OrderID = 0, CustomerID = 1, OrderDate = new DateOnly(2025, 01, 01), Total = 12.51M });
            data.Add(new Order { OrderID = 1, CustomerID = 3, OrderDate = new DateOnly(2023, 02, 28), Total = 21.12M });
            data.Add(new Order { OrderID = 2, CustomerID = 2, OrderDate = new DateOnly(2022, 03, 12), Total = 345.54M });
            data.Add(new Order { OrderID = 3, CustomerID = 6, OrderDate = new DateOnly(2021, 04, 23), Total = 654.53M });
            return data;
        }
    }
}
