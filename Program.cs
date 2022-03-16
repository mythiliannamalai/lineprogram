namespace lineprogram
{
    class program
    {
        public int x1;
        public int x2;
        public int y1;
        public int y2;
        public double a;
        public double b;
        public void Calculation()
        {
            Console.WriteLine("Welcome to the line comparison camputation");
            Console.WriteLine("enter x1 value : ");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter x2 value : ");
             x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter y1 value : ");
             y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter y2 value : ");
             y2 = int.Parse(Console.ReadLine());
             a= Math.Pow(x2 - x1, 2);
             b = Math.Pow(y2 - y1, 2);
            var distance = Math.Sqrt(a + b);
            Console.WriteLine("distance of 2 point is : " + distance);
        }
        public void Equal_not()
        {
            if (a == b)
            {
                Console.WriteLine("both line are equal");
            }
            else
            {
                Console.WriteLine("both line are not equal");
            }
        }
        public void Comparetion()
        {
            if (a > b)
            {
                Console.WriteLine("line1 is greaterthen");
            }
            else if (b > a)
            {
                Console.WriteLine("line2 is greaterthan");
            }
            else
            {
                Console.WriteLine("both line are equal");
            }
        }
        static void Main(string[] args)
        {
            program program =new program();
            program.Calculation();
            program.Equal_not();
            program.Comparetion();
        }
    }
}