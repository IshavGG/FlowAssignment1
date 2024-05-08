using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Flow_Assignment_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Base class instance, Base class object
            Base ab = new Base();
            ab.DoWork();
            // Base class do work

            // Base class instance, Child object
            Base a = new A();
            a.DoWork(); 
            // Base do work

            A aa = new A();
            aa.DoWork();
            //child do work


            Console.WriteLine("+++++++++");
            // Now Base class has virtual keyword
            //Base 
            ab = new Base();
            ab.DoWork();
            // Base class do work

            // Base class instance, Child object
            a = new A();
            a.DoWork();
            // Base do work

            aa = new A();
            aa.DoWork();
            //Child do work



            Console.WriteLine("+++++++++");
            // Now Base class has virtual keyword and child has override
            //Base 
            ab = new Base();
            ab.DoWork();
            // Base class do work

            // Base class instance, Child object
            a = new A();
            a.DoWork();
            // child do work

            aa = new A();
            aa.DoWork();
            //Child do work



            Console.WriteLine("+++++++++");
            // Now Child class has new keyword, Base is normal
            //Base 
            ab = new Base();
            ab.DoWork();
            // Base class do work

            // Base class instance, Child object
            a = new A();
            a.DoWork();
            // Base do work

            aa = new A();
            aa.DoWork();
            //Child do work


            Console.WriteLine("+++++++++");
            // Now Child class has new keyword, Base has virtual
            //Base 
            ab = new Base();
            ab.DoWork();
            // Base class do work

            // Base class instance, Child object
            a = new A();
            a.DoWork();
            // Base do work

            aa = new A();
            aa.DoWork();
            //Child do work

            Console.WriteLine("+++++++++");
            // Now Child class has virtual keyword, Base has virtual
            //Base 
            ab = new Base();
            ab.DoWork();
            // Base class do work

            // Base class instance, Child object
            a = new A();
            a.DoWork();
            // Base do work

            aa = new A();
            aa.DoWork();
            //Child do work




            Console.WriteLine("=================");
            Console.Read();   

        }
    }
}
