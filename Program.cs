namespace nothing01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RecursiveFunction.recursiveFunc(5));    //RecursiveFunction

            Animals human = new Animals();      //check  Animals.cs to see Method OverLoading
            human.walk("1", "2");

            Animals sheep = new Animals();
            sheep.walk("1", "2" , "3","4");

            Numbers.printNumbers(1, 4, 5, 2, 5, 2);     //check Numbers.cs to see params syntax


            var ObjectInitializePerson  = new ObjectInitializePerson
            {
                Name = "John",
                Age = 30
            }; //check ObjectInitializePerson.cs to see Object Initializer Syntax
        }
    }
}
