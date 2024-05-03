namespace hindeline_too
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inp = Convert.ToInt32(Console.ReadLine());
            for ( int i = 0; i < inp; i++)
            {
                Console.WriteLine("Liptoni jäätee," + i + " purki, who wants it?");
            }
        }
    }
}
