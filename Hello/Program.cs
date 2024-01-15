using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hello //container
{
    internal class Program{
        static void Main(string[] args)
        {
            int harry = 43;
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
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello");
            Console.Write("Hello once");
            Console.WriteLine("Shree"+harry);
            Console.ReadLine();
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
            Console.WriteLine("Enter Your name::");
            string name=Console.ReadLine();
            Console.WriteLine("Hello" + name);
            Console.WriteLine("How many candidates you want?");
            string can=Console.ReadLine();
            Console.WriteLine("You will get 4 more candidate"+Convert.ToInt32(can)+4);
            Console.ReadLine();
        }
    }
} 