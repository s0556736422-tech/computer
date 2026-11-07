namespace computer
{
    internal class Program
    {
        public delegate double comDel(double a, double b);
        public static double comAdd(double a, double b )
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            comDel mydel;
            mydel = comAdd;
            Console.WriteLine(mydel(5.2, 10.5));


        }
    }
}
