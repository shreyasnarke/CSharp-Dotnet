using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Text;
using System.Threading.Tasks;
namespace Hello //container
{
    internal class Program{
        //functions
        static void Greet(string name)
        {
            Console.WriteLine("Good morning (Greet function)"+name);
        }
        static int Avg(int a,int b,int c)
        {
            int sum = a + b + c;
            return sum / 3;
        }

        static void Main(string[] args)
        {
            //int harry = 43;
            /*
            Data types-int-4,long-8,double-34.4D-8,float-34.4F-4,char-2,bool-1 bit,string-2/character
            Type Casting - 
            1:Implicit Casting -char to int to long to float to double
            2:Explicit Casting -
                    int x=(int)3.5;
                    int x=3;
                    double y=x;
                    Console.WriteLine(x);
                    Console.ReadLine();
             */
            //Console.WriteLine("Hello world");
            //Console.WriteLine("Hello");
            //Console.Write("Hello once");
            //Console.WriteLine("Shree"+harry);
            //Console.ReadLine();
            /*  
              int x = 3;
              double y = 4;
              float z = 'y';
              float varr = Convert.ToInt32(3.44);
              string ss = "sss";
              Console.WriteLine(x);
              Console.WriteLine(y);
              Console.WriteLine(z);
              Console.WriteLine(varr);
              Console.ReadLine();
            */
            //Console.WriteLine("Enter Your name::");
            //string name=Console.ReadLine();
            //Console.WriteLine("Hello" + name);
            //Console.WriteLine("How many candidates you want?");
            //string can=Console.ReadLine();
            //Console.WriteLine("You will get 4 more candidate"+(Convert.ToInt32(can)+4));
            //Console.ReadLine();

            //OPERATORS IN C#
            //    1.Arithmetic operators
            //    2.Assignment operators
            //    3.Logical operators
            //    4.comparison operators
            //
            // 1.Arithmetic operators
            //int a = 4;
            //int b = 2;
            //Console.WriteLine("The Value of a + b is "+ (a + b));
            //Console.WriteLine("The Value of a - b is " + (a - b));
            //Console.WriteLine("The Value of a * b is " + (a * b));
            //Console.WriteLine("The Value of a / b is " + (a / b));
            //Console.ReadLine();

            //2:Assignment Operator
            //int a = 4;
            //int b = a;
            //b += 4;
            //b -= 4;
            //b /= 4;
            //Console.WriteLine(b);
            //Console.ReadLine();

            ////3:Logical Oprator
            //Console.WriteLine(true && false);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);
            //Console.WriteLine(!false);
            //Console.WriteLine(!true);
            //Console.ReadLine();

            //4.Comparison operators
            //Console.WriteLine(232>411);
            //Console.WriteLine(232 >= 242);
            //Console.WriteLine(2424<=2424);
            //Console.WriteLine(24242!=2322);
            //Console.WriteLine(3434 == 343);
            //Console.ReadLine();

            //Math class methods
            //int a = Math.Min(34,345);
            //Console.WriteLine(a);
            //int b = Math.Max(34,36);
            //Console.WriteLine(b);
            ////sqrt reutrns double data type
            //double c = Math.Sqrt(b);
            //Console.WriteLine(c);
            //double d=Math.Abs(c);
            //Console.WriteLine(d);
            //Console.WriteLine(Math.Round(d));
            //string hello="Hello this is shreyas";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello.IndexOf("is"));
            //Console.WriteLine(hello.Substring(5));
            //string helloo = "Hello\t this \n is shreyas";
            //Console.WriteLine(helloo.Length);
            //Console.ReadLine();

            ////string concatenation method 
            //string name = Console.ReadLine();   
            //string candy=Console.ReadLine();
            //Console.WriteLine($"You are {name}.You will get {candy}");
            //Console.ReadLine();

            //Decision Control methods
            //1.if-else statements
            //Console.WriteLine("Enter your age");
            //string agestr = Console.ReadLine();
            //int age = Convert.ToInt32(agestr);
            //bool isBanned = true;

            //if( age == 6 || isBanned)
            //{
            //    Console.WriteLine("You can capable to drive or banned");
            //}
            //else if(age > 16 || isBanned)
            //{
            //    Console.WriteLine("You can drive or banned");
            //}
            //else
            //{
            //    Console.WriteLine("You cannot drive");
            //}
            //Console.ReadLine();

            //2:Switch condiotionsp
            //int age = 70;
            //switch(age)
            //{
            //    case 18: 
            //        Console.WriteLine("Please wait for year") ;
            //        break;
            //    case 70:
            //        Console.WriteLine("Please wait for 1 year");
            //        break;
            //    default: Console.WriteLine("enjoy");
            //        break;
            //}

            //Loops in C sharp

            //1::While loop
            //int i =0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //2::do..while loop
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i+1);
            //    i++;
            //}while (i < 5);

            //3::for loop
            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 0)
            //    {
            //        continue;//skip 1 output::2,3,4,5
            //    }
            //    Console.WriteLine(i + 1);
            //}

            //Greet("Shreyas");
            //Console.WriteLine(Avg(2,6,8));
            //float temp=Avg(2,5,10);
            //Console.WriteLine(temp);

            //OOP's-Classes and objects
            Class1 tommy = new Class1();
            Console.WriteLine(tommy.health);
            tommy.setHealth(100);
            Console.WriteLine(tommy.getHealth());
            Console.ReadLine();

        }
    }
} 