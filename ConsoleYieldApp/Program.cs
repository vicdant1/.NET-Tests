using ConsoleYieldApp;
using ConsoleYieldApp.Entities;

Console.WriteLine("Program started");

IEnumerable<Person> People = PeopleHelper.GetPeople();

foreach (var person in People)
{
    if (int.Parse(person.Cpf) == 5)
        break;

    Console.WriteLine($"Id: {person.Id} || CPF: {person.Cpf}");
}