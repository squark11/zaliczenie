using System;


namespace try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for two numbers, x and y
            Console.WriteLine("Enter x:");
            int.TryParse(Console.ReadLine(), out int x);
            Console.WriteLine("Enter y:");
            int.TryParse(Console.ReadLine(), out int y);
            // Try dividing x by y - catch exceptions when it goes wrong
            try
            {
                int result = x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch // or catch (Exception) or catch (Exception ex)
            {
                Console.WriteLine("Some general exception!");
            }
            finally
            {
                Console.WriteLine("This is always executed. Closing the app.");
            }
        }
    }
}


