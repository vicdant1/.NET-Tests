using ConsoleYieldApp.Entities;

namespace ConsoleYieldApp
{
    public static class PeopleHelper
    {
        public static IEnumerable<Person> GetPeople()
        {
            for (int i = 0; i < 10; i++)
               yield return new Person(i.ToString());
        }
    }
}
