using System;

namespace BT_AUTO_2021_Programming_lpaul
{
    class Program
    {
        public static void Main(string[] args)
        {
                Course03(static);

            Console.WriteLine("Hello World!");
            Console.WriteLine(6 + 2);
            Console.WriteLine("6 + 2");
        }
        
        {
    class Program
    {
        static void Main(string[] args)
            //Course01(args);
            Course02();
        }

        static void Course01 (string[] args)...

        static void Course02()
        {
            Circle c1 = new Circle();
            Circle c2; // c2 will be null !!!
            c1.SetRadius(10);
            /*double area = c1.GetArea();*/
            /* Console.WriteLine(c1.GetArea());*/
            c1.PrintCircle();
            Circle c3 = new Circle();
            c3.SetRadius(5);
            /*Console.WriteLine(c3.GetArea());*/
            c3.PrintCircle();
            foreach (string p in args)
            {
                Circle c = new Circle();
                c.SetRadius(Double.Parse(p));
                Square s = new Square();
                s.SetSide(Double.Parse(p));
                Rectangle r = new Rectangle();
                r.SetSize(Double.Parse(p), Double.Parse(p));
                c.PrintCircle();
                s.PrintSquare();
                r.PrintRectangle();
            }

            Person p1 = new Person();
            p1.SetName("paul");
            p1.SetSex('m');
            p1.Eat();
            p1.Run();
            p1.Eat();
            p1.PrintPerson();


            Rectangle r1 = new Rectangle();
            r1.SetSize(2, 3);
            r1.PrintRectangle();
        }
    }


       static void Course03(string[] args)
        {
            if (args.Lenght !=3 )
            {
                Console.WriteLine("The application receives only 3 parameters: amount, currency, exchange rate");

            }
            else
            {
                Console.WriteLine("{0} {1} {2}", args[0], args[1], args[2]);
                CurrencyCalculator(Double.Parse(args[0]), args[1], Double.Parse(args[2]));
            }

            CurrencyCalculator(156, "USD", 4.3734);

        }
        
            Shape GetShape(int)

        static void ComputeConversion(string[] args)
        {
            if (args.Lenght !=3 )
            {
                Console.WriteLine("The application receives only 3 parameters: amount, currency, exchange rate");

            }
            else
            {
                Console.WriteLine("{0} {1} {2}", args[0], args[1], args[2]);
                CurrencyCalculator(Double.Parse(args[0]), args[1], Double.Parse(args[2]));
            }

        static void CurrencyCalculator(double amount, string calculator, double conversionRate)
        {
        Console.WriteLine("By converting {0} {1} into RON we obtain {2} RON", amount, currency, amount * conversionRate);
        }
    }

        static string ConcatenateStrings(string[] args)
        {
            string returnString = "";
            foreach (string s in args)
            {
                returnString +=
            }
        }
    }

        static int TestValue(int testVal, int target)
        {
            if (testVal < target)
            {
                return -1;
            }
            if (testVal > target)
            {
                return 1;
            }
            return 

        static void GuessNumber(int n)
        {
            w
        }


        static bool IsOddNumber(int number)
   









        static void Course04()
        {
            DrawFullShape(5, 3);
            Console.WriteLine();
            DrawFullShape2(5, 3);
            Console.WriteLine();
            DrawShapeOutline(14, 22);
            Console.WriteLine();
            DrawShapeCorner(14, 22);
    }

        public static void DrawFullShape(int widht, int height);
        {
            for(int j = 0; j < height; j++)
            {
                for( int i = 0; i < width; i++} ///this will print a single line with * counting width
                {
                    if (j==0 || j==height-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if( if==0 || if ==width-1)

        }