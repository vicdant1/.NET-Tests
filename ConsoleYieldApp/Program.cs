using ConsoleYieldApp;
using ConsoleYieldApp.Entities;

Console.WriteLine("Program started");

IEnumerable<Product> products = ProductManagerHelper.CreateProducts();

EShopManager manager = new EShopManager();

manager.AddToKart(products.First(), products.Last(), products.ElementAt(2));



#region yield_return
//IEnumerable<Person> People = PeopleHelper.GetPeople();

//foreach (var person in People)
//{
//    if (int.Parse(person.Cpf) == 5)
//        break;

//    Console.WriteLine($"Id: {person.Id} || CPF: {person.Cpf}");
//}
#endregion

#region using_statement

/*
 using statement will promote a behave like this piece of code:
    
    try
    {
        instance.something();
    }
    finally
    {
        instance.Dispose();
    }

    It SHOULD be used when we are dealing with classes that implements IDisposable interface.
    This way we are avoiding memory leaks through the program because .NET garbage collector will take a deeper look at it.

    example:

    using(var connection = new SqlConnection())
    {
        connection.Open();
        Command dbCommand = connection.CreateCommand();

        connection.ExecuteCommand(dbCommand);


        using(var dataReader = new System.DataReader())
        {
            dataReader.ReadData(connection);
        }
    }

 */


#endregion


#region params_keyword


public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";

    public Product(string Name)
    {
        this.Id = Guid.NewGuid();
        this.Name = Name;
    }
}

public static class ProductManagerHelper
{
    public static IEnumerable<Product> CreateProducts()
    {
        for (int i = 0; i < 10; i++)
            yield return new Product($"Product {i}");
    }
}

public class EShopManager
{
    public void AddToKart(params Product[] products)
    {
        foreach (Product product in products)
            Console.WriteLine($"Product: {product.Name} ({product.Id})");
    }
}


#endregion