namespace if_ja_else_brah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random RNG_1 = new Random();
            Random RNG_2 = new Random();

            double rng1 = Convert.ToDouble(RNG_1);
            double rng2 = Convert.ToDouble(RNG_2);
            if (rng1 > 0.5)
            {
                Console.WriteLine("Baba is you");
                if (rng2 > 0.9)
                {
                    Console.WriteLine("Baba is me");
                }
                Console.WriteLine("Baba is gone");
            }
            Console.WriteLine("Ancient clocks, gah dayum");
        }
    }
}
