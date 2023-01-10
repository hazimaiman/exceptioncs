using System.Runtime.CompilerServices;

namespace MyFirstProgram
    {
        class Program
        {
        static void Main(string[] args)
        {
            //exception = error that occur during execution
            // try = try some that is considered dangerous
            //catch = catches and handles exceptions when they occurss
            // finally = always executes regardless if exception is caught or not

            double x;
            double y;
            double result;
            try { 
            Console.WriteLine("ENTER NUMBER 1: ");
            x = Convert.ToInt32(Console.ReadLine());
                
            Console.WriteLine("ENTER NUMBER 2: ");
            y = Convert.ToInt32(Console.ReadLine());


            result = x / y;
            Console.WriteLine("result: " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only number please");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You cant divide by 0 ddodoob");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something wrong");
            }
            finally
            {
                Console.WriteLine("Thankyou for visiting");
            }

            Console.ReadKey();
        }
        
    }
    }





   
