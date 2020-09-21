namespace Task01
{
    internal class Program
    {

        public static void FindNumber()
        {
            int s = 0;
            for (int i = 1; i < 1000; i++)
            {
                s += i;
                int res;
                if (i / 10 > 0)
                {
                    res = i % 10;
                    i = i / 10;
                }

            }
        }
        public static void Main(string[] args)
        {
            
        }
    }
}