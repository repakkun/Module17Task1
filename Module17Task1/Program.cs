using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17Task1
{
    //Своё исключение
    public class MyException : Exception
    {
        public MyException()
        { }

        public MyException(string message)
            : base(message)
        { }
    }
    class Program
    {
        static int Division(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[5] { new ArgumentException(), new DivideByZeroException(), new FieldAccessException(), new FormatException(), new MyException("мое исключение") };
            try
            {   
                int result = Division(1, 0);                          
                throw new ArgumentException();
                throw new DivideByZeroException();               
                throw new FieldAccessException();
                throw new FormatException();
                throw new MyException();
            }
            catch(Exception)
            {
                /* for (int i = 0; i < exceptions.Length; i++) 
                 {                  
                     {
                         Console.WriteLine(ex.Message);
                     }
                 }*/
                foreach (Exception ex in exceptions)
                {                 
                    Console.WriteLine(ex.Message);
                }                    
            }
            Console.ReadKey();
        }
    }
}
