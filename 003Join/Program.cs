using _001GroupBy;
using _005.DataAnnotation.Data;

await using var dataContext = new DataContext();

Console.WriteLine("Good look  😊😊😊");

//1
//Получите все заказы с указанием имени клиента и количества заказа клиента.
//Get all orders with customer name and customer order quantity

// var prod = from oi in dataContext.OrderItems
//             join o in dataContext.Orders on oi.OrderId equals o.Id
//             join c in dataContext.Customers on o.CustomerId equals c.Id
//             select new{
//                 Name = c.Name,
//                 ProdName = oi.ProductName,
//                 OrderQuantity = oi.ProductName.Count()
//             };

//             foreach (var item in prod)
//             {
//                 System.Console.WriteLine($"Customer Name: {item.Name} Product Name: {item.ProdName} Quantity: {item.OrderQuantity}");
//             }
        

//2
//Получить все заказы с именем клиента и стоимостью заказа
//Get all orders with customer name and order value

// var prod = from oi in dataContext.OrderItems
//         join o in dataContext.Orders on oi.OrderId equals o.Id
//         join c in dataContext.Customers on o.CustomerId equals c.Id
//         select new
//         {
//             ProdName = oi.ProductName,
//             CustomerName = c.Name,
//             OrederPrice = oi.Price
//         };

//         foreach (var item in prod)
//         {
//             System.Console.WriteLine($"Product Name: {item.ProdName} Customer Name: {item.CustomerName} Price: {item.OrederPrice}");
//         }

//3
//Получите все заказы с указанием имени клиента и количества продукции
//Get all orders with customer name and product quantity:

var prod = from oi in dataContext.OrderItems
        join o in dataContext.Orders on oi.OrderId equals o.Id
        join c in dataContext.Customers on o.CustomerId equals c.Id
        select new 
        {
            CustomerName = c.Name,
            CountProd = oi.ProductName.Count()
        };

foreach (var item in prod)
{
    System.Console.WriteLine($"Customer Name: {item.CustomerName} Count Products: {item.CountProd}");
}
