using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace DateTime___TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Assignment 1: " + "We had to wait " + assignment1() + " days for the sequel!");
            Console.WriteLine("Assignment 2: " + "I am " + assignment2() + " old.");
            Console.WriteLine("Assignment 3: " + "I will be double my current age in " + assignment3());
            Console.WriteLine("Assignment 4: " + "Between 2022 - 3/26 and 2022 - 3/27, there were " + assignment4() + " hours.");
            Console.WriteLine("Assingment 5: " + "Between 2023 - 1/1 and  2024 - 1/1, and 2024 - 1/1 and 2025 - 1/1, there were " 
            + assignment5().Split(",")[0] + " and " + assignment5().Split(",")[1] + " days respectively.");

            Console.WriteLine("Assignment 6: " + "On 2015 - 07/01, between the hours of 1:59:30 and 2:00:30, there were " + assignment6() + " seconds.");
        }

        public static string assignment1()
        {
            DateTime dt1 = new DateTime(2009, 12, 18);
            DateTime dt2 = new DateTime(2022, 12, 06);

            TimeSpan ts = dt2 - dt1;

            return ts.Days.ToString();
        }

        public static string assignment2()
        {
            DateTime now = DateTime.Now;
            DateTime birth = new DateTime(2007, 3, 15);

            TimeSpan age = now - birth;

            string ageDaysHoursMinutesSeconds = 
                  age.Days.ToString() + " Days, " 
                + age.Hours.ToString() + " Hours, " 
                + age.Minutes.ToString() + " Minutes, " 
                + age.Seconds.ToString() + " Seconds";
            return ageDaysHoursMinutesSeconds;
        }

        public static string assignment3()
        {
            DateTime now = DateTime.Now;
            DateTime birth = new DateTime(2007, 3, 15);

            TimeSpan age = now - birth;

            DateTime doubleAge = DateTime.Now + age;

            return doubleAge.Year.ToString() + ".";
        }

        public static string assignment4()
        {
            DateTime dt1 = new DateTime(2022, 3, 26);
            DateTime dt2 = new DateTime(2022, 3, 27);

            TimeSpan ts = dt2 - dt1;
            int hours = ts.Days * 24 + ts.Hours;

            return hours.ToString();
        }

        public static string assignment5()
        {
            DateTime dt1 = new DateTime(2023, 1, 1);
            DateTime dt2 = dt1.AddYears(1);
            DateTime dt3 = dt2.AddYears(1);

            TimeSpan ts1 = dt2 - dt1;
            int days1 = ts1.Days;

            TimeSpan ts2 = dt3 - dt2;
            int days2 = ts2.Days;

            string totaldays = days1 + "," + days2;
            return totaldays;
        }

        public static string assignment6()
        {
            DateTime dt1 = new DateTime(2015, 7, 1, 1, 59, 30); 
            DateTime dt2 = new DateTime(2015, 7, 1, 2, 0, 30); 

            TimeSpan ts = dt2 - dt1;
            int seconds = ts.Minutes * 60;

            return seconds.ToString();
        }
    }
}
