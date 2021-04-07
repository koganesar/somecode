using System;
namespace Exceptions
{
    class ExeptionCheking
    {
        public int a;

        public ExeptionCheking(int a)
        {
            this.a = a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SimpleMethod(5, 0, new ExeptionCheking(5), true);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                SimpleMethod(5, 4, null, true);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                SimpleMethod(6, 7, new ExeptionCheking(5), true);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                SimpleMethod(5, 4, new ExeptionCheking(5), false);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static double SimpleMethod(int x, int y, ExeptionCheking exeptionCheking, bool test)
        {
            var array = new int[x];
            _ = array[y];

            if (exeptionCheking is null)
            {
                throw new ArgumentNullException("ExeptionCheking null");
            }

            bool flag = true;

            _ = !test ? Convert.ToChar(flag) : 'a';
            _ = exeptionCheking.a;

            return x / y;
        }
    }
}