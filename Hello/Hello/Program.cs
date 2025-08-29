using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is important foe deebugging . do not remove 
            /*
            This is a multi-line comment 
            sppanning multiple lines 
             */
            //making a integer variable in that way 
            int muzamil = 34;
            Data types in C#
              Integer => int muzamil;    --> 4 bytes
              Floating point number => float that; --> 4 bytes 
              Character => char a = 'A';   --> 2 byte 
              Boolean => bool isGreat = true ;  --> 1 bit 
              String => string inp = "Muzamil";  --> 2 bytes per character
              Long =>  Long muzamil --> 8 bytes 
              Double => double muzamil --> 8 bytes 
             
            // read line jo hota hai vo humay ak string return krta hai 
            string inp = Console.ReadLine();
            Console.WriteLine(inp);
            Console.WriteLine(" Hello World");
            Console.Write("Hello Muzamil");
            Console.WriteLine(" I Love C# and the number " + muzamil);
            Console.ReadLine();

            //Data types example
            int a = 34;
            float b = 34.4F;
            double c = 34.4D;
            bool isGreat = true;
            char d = 'm';
            string e = "This is a string";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(isGreat);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(a + b);
            Console.ReadLine();
            //multipal jaga pr ak sath likhny ka shortcut =>{ Alt +ctrl + vo jaga tab jha cursor chayie }

            // Type castining 
            //There is the two types of type casting
            // 1. Implicit Casting
            //char to int to long to float  to doule
            // 2.Explicit Csting 
            int a = (int)5.5;
            double x1 = (double)6.5;
            Console.WriteLine(x1);
            int x = 3;
            double y = x;
            int z = 'y';
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(a);
            Console.WriteLine(z);
            float varr = Convert.ToInt32(8.55);
            Console.WriteLine(varr);
            covert.ToDouble
            convert.ToString
            string w = "Random string";
            Console.WriteLine(w);
            Console.ReadLine();

            // user input 
            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine(" Hey Hello " + name);

            Console.WriteLine("How many candies do you want? ");
            string can = Console.ReadLine();
            Console.WriteLine(" You will get 4 more candies " + (Convert.ToInt32(can) + 4));
            Console.ReadLine();
            //jb can = console.read line kya yeh to ak string return kr rahi hai yeh  ak rule hai jb koi numeber jora jata hai to vo is ko be ak string may convert kr sakti hai 

            //about operator in C#
            /*
             1. Arithmetic Operators
             2. Assignment operator
             3. logical Operator 
             4. Comparison operators
             */
            int a = 3;
            int b = 5;
            Console.WriteLine("The value of a+b is = " + (a + b));
            Console.WriteLine("The value of a-b is =" + (a - b));
            Console.WriteLine("The value of a*b is =" + (a * b));
            Console.WriteLine("The value of a/b is =" + (a / b));
            Console.ReadLine();

            //Assignment Operator
            int a = 4;
            int b = a;
            b += 4;
            b -= 4;
            b *= 4;
            b /= 4;
            Console.WriteLine(b);
            Console.ReadLine();

            // Logical Operators
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);
            Console.ReadLine();
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);
            Console.ReadLine();
            Console.WriteLine(!false);
            Console.WriteLine(!true);
            Console.ReadLine();

            // Comparison Operators
            Console.WriteLine(324 > 555);
            Console.WriteLine(324 <= 555);
            Console.WriteLine(324 >= 555);
            Console.WriteLine(324 != 555);
            Console.WriteLine(5 == 5);
            Console.ReadLine();

            // Math Operation
            int a = Math.Max(34, 345);
            Console.WriteLine(a);
            int b = Math.Min(34, 345);
            Console.WriteLine(b);
            double c = Math.Sqrt(34);
            Console.WriteLine(c);
            int d = Math.Abs(-34);
            Console.WriteLine(d);
            Console.ReadLine();

            //String
            string hello = "Hello world this is Muzamil";
            Console.WriteLine(hello.Length);
            Console.WriteLine(hello.ToUpper());
            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello + " You are a very sweet girl");
            Console.WriteLine(string.Concat(hello + " You are a very sweet girl"));
            string name = Console.ReadLine();
            string candies = Console.ReadLine();
            //// string interpolation : plus ki jaga pr use kya jata hai 
            Console.WriteLine($"Your name is {name}. You will get {candies} candies");
            Console.ReadLine();
            string hello = "Hello world this is Muzamil";
            Console.WriteLine(hello[0]);
            Console.WriteLine(hello[1]);
            Console.WriteLine(hello[2]);
            Console.WriteLine(hello[3]);
            Console.WriteLine(hello[4]);
            Console.WriteLine(hello[5]);
            Console.WriteLine(hello.IndexOf("Muzamil"));
            Console.WriteLine(hello.Substring(5));
            Console.ReadLine();

            //Escape Sequence Characters
            string h = "Hello world this \t is Muzamil";
            string hello = "Hello world this \" is Muzamil";
            Console.WriteLine(hello);
            Console.WriteLine(h);
            Console.ReadLine();
            decisional statement : conditional statement
             if else ladder
            Console.WriteLine("Enter Your  age ");
            string ageStr = Console.ReadLine();
            int age = Convert.ToInt32(ageStr);
            bool isBanned = true;
            if (age >= 18)
            {
                Console.WriteLine("You can drive ");
            }
            else if (age < 10 || isBanned)
            {
                Console.WriteLine("Please finish your height");
            }
            else if (age < 1 || isBanned)
            {
                Console.WriteLine("You are just born or banned ");
            }
            else
            {
                Console.WriteLine("You can't drive ");
            }
            Console.ReadLine();
            Switch
            int age = 78;
            switch (age)
            {
                case 18:
                    Console.WriteLine("Please wait for an year ");
                    break;
                case 20:
                    Console.WriteLine("You are 20");
                    break;
                default:
                    Console.WriteLine("Enjoy!");
                    break;

            }
            Console.ReadLine();
            Loops is c sharp
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i > 5);
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                Console.WriteLine(i + 1);
            }
            break -> leave this loop for ever
            continue -> leave this particular iteration of the loop

            // Methods & Function  =>  
            Console.ReadLine();
        }
    }
}

