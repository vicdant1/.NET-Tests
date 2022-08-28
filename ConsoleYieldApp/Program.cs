using ConsoleYieldApp;
using ConsoleYieldApp.Entities;

Console.WriteLine("Program started");


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