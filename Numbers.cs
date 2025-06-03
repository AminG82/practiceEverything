namespace nothing01
{
    public class Numbers
    {
        public static void printNumbers(params int[]numArray)
        {
            for(int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }
                
        }
    }
}
