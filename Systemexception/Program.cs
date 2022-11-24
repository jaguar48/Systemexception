

using System;
using System.Collections.Generic;
using System.Collections;


namespace ATM_PROJECT
{
    public class InvalidAgeException : Exception
    {


        public InvalidAgeException(string message)
            : base(message)
        { }
           
    }
    
    public class Myeven
    {
        public static void ValidastEven()
        {
            Console.WriteLine("Your age must be even number");
            int my_age = Convert.ToInt32(Console.ReadLine());
            if (my_age % 2 != 0)
            {

                throw new InvalidAgeException("Unable to find age")
            }
            else {
                return my_age;
            }
        }
    }


    class Program
    {

        public static void Main(string[] args)
        {
            try
            {
                Myeven.ValidastEven();
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                Console.WriteLine($"Source: {ex.Source}");
                
            }
            catch (DivideByZeroException dividebyzero)
            {
                Console.WriteLine("Number {0} can't be divide by zero.", dividebyzero.Message);
            }
          

        }
    }

}
