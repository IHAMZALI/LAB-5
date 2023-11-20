using System;
using System.Linq;

namespace example4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = { "Sun", "mon", "tue", "wed", "thurs", "fri", "sat" };
            PrintArray(weekDays);
            ChangeArray(weekDays);

            Console.WriteLine("arrray weekdays after the call to change array:  ");
            PrintArray(weekDays);
            System.Console.WriteLine();
            ChangeArrayElements(weekDays);
            Console.WriteLine("ARRAYS WEEKDAYS AFETR THE CALL THE CHANGE ARRRAY ELEMENTS: ");
            PrintArray(weekDays);
        }
        private static void ChangeArrayElements(string[] weekDays)
        {
            weekDays[0] = "sat";
            weekDays[1] = "fri";
            weekDays[2] = "thurs";

            Console.WriteLine("arr[0] is {0} in changearrayelements. ", weekDays[0]);

        }
        private static void ChangeArray(string[] weekDays)
        {
            weekDays = (weekDays.Reverse()).ToArray();
            Console.WriteLine("arr[0] is {0} in changearrayelements. ", weekDays[0]);
        }
        public static void PrintArray(string[] weekDays)
        {
            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.Write(weekDays[i] + "{0}", i < weekDays.Length - 1 ? "  " : "");
            }

            Console.WriteLine();

        }
    }
}