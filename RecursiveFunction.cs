namespace nothing01
{
    public class RecursiveFunction
    {
        public static int recursiveFunc(int input)
        {
            if (input <= 1)
            {
                return 1;
            }
            return input * recursiveFunc(input - 1);
        }
    }
}
