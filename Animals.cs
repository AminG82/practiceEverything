namespace nothing01
{
    /// <summary>
    /// Represents animals and provides methods to simulate walking behavior.
    /// </summary>
    public class Animals
    {
        /// <summary>
        /// Simulates a two-legged animal walking.
        /// </summary>
        /// <param name="leg1">The first leg.</param>
        /// <param name="leg2">The second leg.</param>
        public void walk(string leg1, string leg2)
        {
            Console.WriteLine("2 leg animal is walking");
        }

        /// <summary>
        /// Simulates a four-legged animal walking.
        /// </summary>
        /// <param name="leg1">The first leg.</param>
        /// <param name="leg2">The second leg.</param>
        /// <param name="leg3">The third leg.</param>
        /// <param name="leg4">The fourth leg.</param>
        public void walk(string leg1 , string leg2 , string leg3 , string leg4)
        {
            Console.WriteLine("4 leg animal is now woalking");
        }
    }
}
