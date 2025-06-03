namespace nothing01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RecursiveFunction.recursiveFunc(5));    //RecursiveFunction

            Animals human = new Animals();      //check the Animals Class to see understand Method OverLoading
            human.walk("1", "2");

            Animals sheep = new Animals();
            sheep.walk("1", "2" , "3","4");
        }
    }
}
