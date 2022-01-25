using System;

namespace Test_Dikt
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dictionary<char, Person> people = new Dictionary<char, Person>();
            people.Add('b', new Person() { Name = "Bill" });
            people.Add('t', new Person() { Name = "Tom" });
            people.Add('j', new Person() { Name = "John" });

            foreach (KeyValuePair<char, Person> keyValue in people)
            {
                // keyValue.Value представляет класс Person
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Name);
            }

            // перебор ключей
            foreach (char c in people.Keys)
            {
                Console.WriteLine(c);
            }

            // перебор по значениям
            foreach (Person p in people.Values)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}
