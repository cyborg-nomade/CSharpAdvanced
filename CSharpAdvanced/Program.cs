using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
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
            }*/

            /*StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(@"C:\Users\urielf\test\file.txt");
                var content = streamReader.ReadToEnd();
                throw new Exception("Oops");
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, an unexpected error occurred");
                Console.WriteLine("Description: " + e);
            }
            finally
            {
                streamReader?.Dispose();
            }*/

            /*try
            {
                using var streamReader = new StreamReader(@"C:\Users\urielf\test\file.txt");
                var content = streamReader.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, an unexpected error occurred");
                Console.WriteLine("Error description: " + e);
            }*/


            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("uriel");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
