using System;
public class Person
{
    public string FirstName;
    public string LastName;
    public DateTime Age;

    public override string ToString()
    {
        for(int i=0; i>=; i++){

        }
        return "Person:" + FirstName + " " + LastName + " " + Age;
    }
}
namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
             
            var person = new Person  { FirstName = "Bilge", LastName = "Tad", Age = new DateTime(1997, 07, 12) };
            var person1 = new Person { FirstName = "Hatice", LastName = "Tüysüz", Age = new DateTime(1996, 11, 11) };
            var person2 = new Person { FirstName = "Theresa", LastName = "Willmann", Age = new DateTime(1996, 08, 18) };
            var person3 = new Person { FirstName = "Yasemin", LastName = "Eken", Age = new DateTime(1999, 07, 19) };
            var person4 = new Person { FirstName = "Helen", LastName = "Müller", Age = new DateTime(2000, 04, 22) };
            Console.WriteLine(person);
        }
    }

}
