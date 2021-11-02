using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReoorderedPowerOfTwo
{
    class Vehicle
    {
        public double distance = 0.0;
        public double hour = 0.0;
        public double fuel = 0.0;

        public Vehicle(double distance, double hour, double fuel)
        {
            this.distance = distance;
            this.hour = hour;
            this.fuel = fuel;
        }

        public void Average()
        {
            double average = 0.0;
            average = distance / fuel;
            Console.WriteLine("Vehicle Average is {0:0.00}", average);
        }

        protected internal virtual void Speed()
        {
            double speed = 0.0;
            speed = distance / hour;
            Console.WriteLine("Vehicle Speed is {0:0.00}", speed);
        }
    }

    //class Car : Vehicle
    //{
    //    public override void Speed()
    //    {
    //        double speed = 0.0;
    //        speed = distance / hour;
    //        Console.WriteLine("Car Speed is {0:0.00}", speed);
    //    }
    //    public Car(double distance, double hour, double fuel)
    //        : base(distance, hour, fuel)
    //    {
    //    }
    //    public void Average()
    //    {
    //        double average = 0.0;
    //        average = distance / fuel;
    //        Console.WriteLine("Car Average is {0:0.00}", average);
    //    }


    //}

    class Employee
    {
        public string Name { get; set; }

        public Employee(string name) { }
        //public string get_Name() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
           // Console.WriteLine(isPowerOfTwo(46));
            isReorderedPowerOfTwo(7);
            List<string> names = new List<string>();
            names.AddRange(new string[] { "Arun", "Kiran", "Meena", "Sachin", "Komal" });
            int ind = names.BinarySearch("Meena");
            //Console.Write(ind);

            Numbers x = new Numbers();
            x.Data = 3;
            Numbers y = new Numbers();
            y = x;
            y.Data = 4;
            Console.WriteLine(x.Data);

            //int[] nos = new int[] { 10, 15, 12, 14 };
            //int[] nos = { 10, 15, 12, 14 };
            //var nos = { 10, 15, 12, 14 };
            //var nos = new int[] { 10, 15, 12, 14 };
            //Array nos1 = new Array { 10, 15, 12, 14 };

            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //dict.Add(1, "Gauri");
            //dict.Add(2, "Naresh");
            ////dict.Add(2, "Lalit");
            //dict.Add(3, "Jayesh");

            //B1 obj = new B1("Hello");

            //int x1 = new int();
            //x1 = 20;
            //int y1 = new int();
            //y1 = x1;
            //y1 = 30;
            //Console.WriteLine(x1);

            //int n1 = 10, n2 = 2, a, s;
            //AddSub(n1, n2, out a, out s);
            //Console.WriteLine("Add: " + a + ", Sub: " + s);
            //Employee emp1 = new Employee("Amol");
            //Employee emp2 = emp1;
            //Console.WriteLine(emp1 == emp2);
            //Console.WriteLine(Employee.ReferenceEquals(emp1, emp2));
            //C obj1 = new C("data");
            //int n;
            //int value = Calc(out n);
            //Console.WriteLine(value);

            //SortedList al = new SortedList();
            //al.Add("11", 20);
            //al.Add(23, "Hello");
            //al.Add("31", new Employee1 { EmpId = 1, Name = "Shailesh", Salary = 450000 });
            //al.Add('4', 40);
            //foreach (DictionaryEntry item in al)
            //{
            //    Console.Write(item.Key + "\t");
            //}

            //File.Open("MyFile.txt", FileMode.Create);
            //File.Open("MyFile.txt", FileMode.Create, FileAccess.Write);
           // File.Open("MyFile.txt", FileMode.Re);
            FileInfo file = new FileInfo("MyFile.txt");
            file.Open(FileMode.Create);
            Console.ReadKey();


            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static int Calc(out int n)
        {
            int i = 1;
            n = 7;
            for (int j = 1; j <= n; j++)
            {
                i = i * j;
            }
            return i;
        }
        static void AddSub(int n1, int n2, out int a, out int s)
        {
            a = n1 + n2;s = 0;
        }
        class A1
        {
            public A1() { }
            public A1(string data) { }
        }
        class B1 : A1
        {
            public B1() { }
            public B1(string data) { }
        }

        class A
        {
            public A() { Console.WriteLine("A-default"); }
            public A(string data) { Console.WriteLine("A-parameterised"); }
        }
        class B : A
        {
            public B() { }
            public B(string data) { }
        }
        class C : B
        {
            public C() { }
            public C(string data) { }

        }

        class Numbers
        {
            public int Data;
        }

        static bool isPowerOfTwo(int x)
        {
            return x != 0 && ((x & (x - 1)) == 0);
        }

        static void isReorderedPowerOfTwo(int x)
        {
            int[] digits = new int[10];
            string str = x.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                digits[str[i] - '0']++;
                Console.WriteLine(str[i] - '0');
            }
        }
    }
}
