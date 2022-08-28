using ConsoleYieldApp.Entities;

namespace ConsoleYieldApp
{
    public static class PeopleHelper
    {
        public static IEnumerable<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i <= 10; i++)
            {
                people.Add(new Person(i.ToString()));
            }

            return people;
        }


    }
}
