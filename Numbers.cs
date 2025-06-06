namespace nothing01
{
    /// <summary>
    /// Provides utility methods for working with numbers.
    /// </summary>
    public class Numbers
    {
        /// <summary>
        /// Prints each number in the specified array to the console.
        /// </summary>
        /// <param name="numArray">An array of integers to print.</param>
        public static void printNumbers(params int[] numArray)
        {
            for(int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }
        }
    }
}
