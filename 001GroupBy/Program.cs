using _001GroupBy;
using _005.DataAnnotation.Data;

await using var dataContext = new DataContext();


Console.WriteLine("Good look  😊😊😊");


//1
//Получить количество заказов для каждого клиента
//Get the number of orders for each customer

// var query = dataContext.Orders.GroupBy(e=>e.Customer).Select(g=> new{ Customer = g.Key,Count = g.Count()}).ToList();

// foreach (var result in query)
//         {
//             Console.WriteLine($"{result.Customer.Name}: {result.Count} orders");
//         }

//2
//Получить общую стоимость заказов для каждого клиента
//Get the total cost of orders for each customer


// // var result1 = dataContext.OrderItems.GroupBy(x => x.Order.Customer).Select(x=> new {Client = x.Key,amount = x.Sum(x=>x.Price)});
// // foreach (var item in result1)
// // {
// //     Console.WriteLine($"{item.Client.Name} {item.amount}");
// }

//3
//Получить среднюю стоимость заказов для каждого клиента
//Get the average order value for each customer

// var query = dataContext.OrderItems.GroupBy(x=>x.Order.Customer).Select(x=> new{Client = x.Key, Avg = x.Average(x=> x.Price) });

// foreach (var item in query)
// {
//     System.Console.WriteLine($"{item.Client.Name} {item.Avg:C}");
// }

