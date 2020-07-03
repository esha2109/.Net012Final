using System;

namespace Final.NET012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[100];
            Adult adult = new Adult();
            Child child = new Child();

            Console.WriteLine(adult.FirstName);
            Console.WriteLine(adult.LastName);
            Console.WriteLine(child.FirstName);
            Console.WriteLine(child.LastName);

        }
    }
    public class Adult
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Adult(){
            this.FirstName = "Syeda";
            this.LastName = "Esha";

         }
     }

    public class Child
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Child()
        {
            this.FirstName = "Baby";
            this.LastName = "Jonus";

        }

    }
}
