namespace Stair_Count
{
    public class StaircaseClimb
    {
        public static int CountVariants(int stairCount)
        {
            if (stairCount <= 1)
            {
                return 1;
            }

            return CountVariants(stairCount - 1) + CountVariants(stairCount - 2);
        }

        public static void Main(string[] args)
        {
            int stairCount = 15;
            int variants = CountVariants(stairCount);

            Console.WriteLine($"Number of ways to climb {stairCount} stairs: {variants}");
        }
    }
}

