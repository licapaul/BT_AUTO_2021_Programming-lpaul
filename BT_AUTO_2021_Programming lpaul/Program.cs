using System;

namespace BT_AUTO_2021_Programming_lpaul
{
    class Program
    {
        public static void Main(string[] args)
        {
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
}
