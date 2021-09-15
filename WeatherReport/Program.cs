using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib mitu kraadi õues on;
            ///Kui õues on rohkem kui 35 kraadi, programm kuvab" Boiling hot";
            //Kui õues on 30 kuni 3 kraadi, programm kuvab "Hot";
            //Kui õues on 20 kuni 30 kraadi, programm kuvab "Nice";
            //Kui õues on 10 kuni 200 kraadi, programm kuvab "Chilly";
            //Kui õues on 0 kuni 10 kraadi, programm kuvab "cold";
            //Kui õues on alla 0 kraadi, programm kuvab "Freezin cold".

            Console.WriteLine("Mitu Kraadi õues on?");
            int Temp = Convert.ToInt32(Console.ReadLine());

            if (Temp >= 35 && Temp <
            {
                Console.WriteLine("Boiling hot");
            }
            else if (Temp >= 30)
                Console.WriteLine("hot");
            }
            else if (temp >= 20)
                 Console.WriteLine("nice")
            }
            else if(temp >= 10)
                    Console.WriteLine("chilly")





}
