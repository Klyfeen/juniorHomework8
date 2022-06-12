using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juniorHomework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleQueue;
            int waitingHours;
            int waitingMinutes;
            int totalWaitingTime;
            int minutesPerHour = 60;
            int minutesPerPerson = 10;

            Console.Write("Введите количество человек в очереди: ");
            peopleQueue = Convert.ToInt32(Console.ReadLine());
            totalWaitingTime = peopleQueue * minutesPerPerson;
            waitingHours = totalWaitingTime / minutesPerHour;
            waitingMinutes = totalWaitingTime % minutesPerHour;
            Console.WriteLine($"Вы должны отстоять в очереди {waitingHours} часа и {waitingMinutes} минут.");
        }
    }
}
