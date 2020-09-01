using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {           
            Random x = new Random();
            int c = x.Next(0, 4);
            int t = x.Next(0, 4);
            int w = x.Next(0, 4);
            int r = x.Next(0, 4);
            string cloud;
            string temperature;
            string wind;
            string rain;

            if (c == 1)
            {
                cloud = "малооблачно";
            }
            else if (c == 2)
            {
                cloud = "облачно";
            }
            else  
            {
                cloud = "пасмурно";
            }

            if (t == 1)
            {
                temperature = "прохладно";
            }
            else if (t == 2)
            {
                temperature = "тепло";
            }
            else 
            {
                temperature = "жарко";
            }

            if (w == 1)
            {
                wind = "слабый ветер колышет волосы";
            }
            else if (w == 2)
            {
                wind = "ветер колышет ветви деревьев";
            }
            else 
            {
                wind = "ветер срывает крыши";
            }

            if (r == 1)
            {
                rain = "кратковременный дождь";
            }
            else if (r == 2)
            {
                rain = "дождь в течении дня";
            }
            else
            {
                rain = "ливень";
            }

            Console.WriteLine($"По прогнозу завтра будет {temperature}, {cloud}, {rain} и {wind}. ");


            Console.ReadKey();
        }
    }
}
