using _005.DataAnnotation.Data;

await using var dataContext = new DataContext();


Console.WriteLine("Good look  😊😊😊");

//1
//Получить все заказы, сделанные клиентом с именем "Ahmad", а также все заказы, в которых был заказан товар с названием "Water"
//Retrieve all orders placed by a customer named "Ahmad" as well as all orders that included a product named "Water"
//    Найти все заказы, сделанные клиентом с именем "Ahmad"
        // var query = dataContext.OrderItems.Where(o => o.Order!.Customer!.Name == "Ahmad" && o.ProductName =="Banana");

        // // Вывести результат
        // foreach (var item in query)
        // {
        //     Console.WriteLine($"Order ID: {item.ProductName}");
        // }
    


//2
//Получить все заказы, сделанные клиентом с именем "Akmal", а также все заказы, в которых был заказан товар с названием "Banana"
//Retrieve all orders placed by a customer named "Akmal" as well as all orders that included a product named "Banana"
    // var query = dataContext.OrderItems.Where(o => o.Order!.Customer!.Name == "Ahmad" && o.ProductName =="Banana");

        // // Вывести результат
        // foreach (var item in query)
        // {
        //     Console.WriteLine($"Order ID: {item.ProductName}, Customer ID: {item.Id}");
        // }
    

dataContext.Database.EnsureDeleted();



