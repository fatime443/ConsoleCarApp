using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_lesson
{
    class Car
    {
        public string Marka;
        public string Model;
        public decimal MaxFuel;
        public decimal CurrentFuel;
        private decimal FuelEffect;
        public decimal LocalKm;
        private decimal GlobalKm;
        public Car(string marka, string model, decimal currentFuel = 12, decimal maxfuel = 80,  decimal fuelEffect=50)
        {
            Marka = marka;
            Model = model;
            MaxFuel = maxfuel;
            CurrentFuel = currentFuel;
            FuelEffect = fuelEffect;
        }
        public void Go()
        {
            int b = 0;
            while (b == 0)
            {

                Console.Write("How many km do you want to go?:");
                string neededKm = Console.ReadLine();
                if (Utilities.IsNumber(neededKm))
                {
                    decimal needIntKm = Convert.ToDecimal(neededKm);
                    if (CurrentFuel > needIntKm / 100 * FuelEffect)
                    {
                        CurrentFuel -= needIntKm / 100 * FuelEffect;
                        Console.WriteLine($"You drove {needIntKm} km and you have {CurrentFuel} l fuel");
                        b++;
                        LocalKm += needIntKm;
                        GlobalKm += needIntKm;
                    }
                    else
                    {
                       decimal needL = CurrentFuel - needIntKm / 100 * FuelEffect;
                        Console.WriteLine($"You need {needL} l and you don't have enough fuel. You have to refuel your car!");
                    }
                }
            }



        }

        public void TopUp()
        {
            int b = 0;
            while (true)
            {
                Console.Write($"How many litr do you want fuel?:{MaxFuel} l; Current Fuel: {CurrentFuel} l: write full or needed: ");
                string neededL = Console.ReadLine();
                if (neededL == "full")
                {
                    CurrentFuel = MaxFuel;
                    Console.WriteLine($"Goof way! You have {CurrentFuel} l!");
                    b++;
                }

                else if (Utilities.IsNumber(neededL))
                {
                    decimal fuel = Convert.ToDecimal(neededL);
                    if (MaxFuel > fuel + CurrentFuel)
                    {
                        CurrentFuel += fuel;
                        Console.WriteLine($"Goof way! You have {CurrentFuel} l!");

                        b++;
                    }
                    else
                    {
                        Console.WriteLine($"Needed fuel more than {MaxFuel} l");
                    }
                    
                }
            }
           
        }

        public void Stop()
        {
            Console.WriteLine($"Local km: {LocalKm}; Global km: {GlobalKm}; ");
        }
        public void Reset()
        {
            LocalKm = 0;
            Console.WriteLine($"Local km: {LocalKm}; Global km: {GlobalKm}; ");

        }
    }
}
