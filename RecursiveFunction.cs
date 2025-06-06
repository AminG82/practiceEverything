namespace nothing01
{
    /// <summary>
    /// Provides methods for recursive operations.
    /// </summary>
    public class RecursiveFunction
    {
        /// <summary>
        /// Calculates the factorial of a given integer using recursion.
        /// </summary>
        /// <param name="input">The integer to calculate the factorial for.</param>
        /// <returns>The factorial of the input integer.</returns>
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
