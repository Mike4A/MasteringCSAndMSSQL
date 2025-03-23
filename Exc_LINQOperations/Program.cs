using LINQOps;
using System.Xml.Linq;

List<Person> people = Tester.GeneratePersonData();

var adults = people.Where(p => p.Age >= 18);
Console.WriteLine("Adults:");
foreach (var adult in adults)
{
    Console.WriteLine($"{adult.FullName} is old enought to vote.");
}

Console.WriteLine("\nNames only:");
var names = people.Select(p => p.FullName);
foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("\nSorted Names:");
var sortedPeople = people.OrderBy(p => p.LastName).ThenBy(p => p.FirstName);
foreach (var person in sortedPeople)
{
    Console.WriteLine(person.FullName);
}


var peopleByAge = people.GroupBy(p => p.Age);
foreach (var group in peopleByAge)
{
    Console.WriteLine($"\nThese Persons are {group.Key} years old:");
    foreach (var person in group)
    {
        Console.WriteLine(person.FullName);
    }
}

List<Customer> customers = Tester.GenerateCustomerData();
List<Order> orders = Tester.GenerateOrderData();

var query = from c in customers
            join o in orders on c.CustomerID equals o.CustomerID
            select new { c.Name, o.OrderDate, o.Total };
Console.WriteLine("\n");
foreach (var item  in query)
{ 
    Console.WriteLine(item);
}

bool hasAdults = people.Any(p => p.Age >= 18);
bool allAdults = people.All(p => p.Age >= 18);
var firstAdult = people.First(p => p.Age >= 18);
var firstAdultOrNull = people.FirstOrDefault(p => p.Age >= 18);

var adultsInNewYork = from p in people
                      where p.Age >= 18 && p.City == "New York"
                      orderby p.LastName, p.FirstName
                      select new { p.FullName, p.Age };
Console.WriteLine("\n");
foreach (var person in adultsInNewYork)
{
    Console.WriteLine($"{person.FullName}, Age: {person.Age}");
}

//XDocument doc = XDocument.Load("books.xml");
//var cheapBooks = from book in doc.Descendants("book")
//                 where (double)book.Element("price") < 10
//                 select new
//                 {
//                     Title = (string)book.Element("title"),
//                     Author = (string)book.Element("author"),
//                     Price = (double)book.Element("price")
//                 };
//foreach (var book in cheapBooks)
//{
//    Console.WriteLine($"{book.Title} by {book.Author} - ${book.Price}");
//}

//using (var context = new NorthwindContext())
//{
//    var expensiveProducts = from p in context.Products
//                            where p.UnitPrice > 50
//                            orderby p.UnitPrice descending
//                            select new { p.ProductName, p.UnitPrice };
//    foreach (var product in expensiveProducts)
//    {
//        Console.WriteLine($"{product.ProductName}: ${product.UnitPrice}");
//    }
//}