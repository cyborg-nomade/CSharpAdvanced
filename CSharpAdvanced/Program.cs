using System;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Sorry, you cannot divide by zero\n" + e);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Sorry, an arithmetic error occurred\n" + e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, an unexpected error occurred\n" + e);
            }
            finally
            {

            }
        }
    }
}
