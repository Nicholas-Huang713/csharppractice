using System;
using System.Collections.Generic;

namespace practice
{
    public class Vehicle
    {
        public int NumPassengers;
        public Vehicle(int val)
        {
            NumPassengers = val;
        }
    }
    public class Program
    {
        static void Main(string[] args)  
        {
            // Random rand = new Random();
            // System.Console.WriteLine(rand.Next(2,8)); 
            // int[] numArr = new int[5];
            // int[] numArr2 = {1,2,3,4,5};

            // List<string> bikes = new List<string>();
            // bikes.Add("Mountain Bike");
            // bikes.Add("Beach Bike");

            // Vehicle myVehicle = new Vehicle(7);
            // Console.WriteLine($"I have {myVehicle.NumPassengers} vehicles");

            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1/num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                
            }
            Console.ReadLine();
        }
    }
}
