using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           int n;
            Console.WriteLine("n = ");
                n = int.Parse(Console.ReadLine());

        //  public  static Airplane ReadAirplaneArray(Airplane[] airplanes, int n) { 
            
                
                
            Airplane[] airplanes = new Airplane[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Airplane {i}");
                Console.Write("Start City");
                string startCity = Console.ReadLine();
                Console.Write("Finish City");
                string finishCity = Console.ReadLine();
                Console.Write("Start Day");
                int startDay = int.Parse(Console.ReadLine());
                Console.Write("Start Month");
                int startMonth = int.Parse(Console.ReadLine());
                Console.Write("Start Year");
                int startYear = int.Parse(Console.ReadLine());
                Console.Write("Start Hours");
                int startHours = int.Parse(Console.ReadLine());
                Console.Write("Start Minutes");
                int startMinutes = int.Parse(Console.ReadLine());
                Console.Write("Finish Day");
                int finishDay = int.Parse(Console.ReadLine());
                Console.Write("Finish Month");
                int finishMonth = int.Parse(Console.ReadLine());
                Console.Write("Finish Year");
                int finishYear = int.Parse(Console.ReadLine());
                Console.Write("Finish Hours");
                int finishHours = int.Parse(Console.ReadLine());
                Console.Write("Finish Minutes");
                int finishMinutes = int.Parse(Console.ReadLine());
                airplanes[i] = new Airplane(startCity, finishCity, new Date(startDay, startMonth, startYear, startHours, startMinutes), new Date(finishDay, finishMonth, finishYear, finishHours, finishMinutes));

                // return airplanes[n];              
                }
           

    }
    }
}
