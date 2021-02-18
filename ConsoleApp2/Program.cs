using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            var date1 = $"{date:d}";
            var dat2 = "";
            var da2 = DateTime.Today.AddDays(-1);
            var date2 = $"{da2:d}";
            int mn = 0;
            int pyr = 0;
            int nyr = 0;

            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine($"{date:d} at {date:t}");
            Console.WriteLine(date.ToString("dd"));
            Console.WriteLine(date.ToString("MM"));
            Console.WriteLine(date.ToString("yyyy"));
            DayOfWeek wk = DateTime.Today.DayOfWeek;
            Console.WriteLine(wk);

            Console.WriteLine("Enter the value");
            var num = Console.ReadLine();
            int l = num.Length;
            var tex = "SO";
            var text = "";
            for (int i = 0; i < 1; i++)
            {

                text = $"{ num[i]}{num[i + 1]}";

                if (tex.Equals(text))
                {
                

                }
                else
                {
                    Console.WriteLine("Invalid input the text must be in capital letter");
                    break;
                }

                var pyear = $"{num[i + 3]}{num[i + 4]}";
                var nyear = $"{num[i + 5]}{num[i + 6]}";
                pyr = Convert.ToInt32(pyear);
                nyr = Convert.ToInt32(nyear);

                var year = pyear + nyear;
                Console.WriteLine("Previous year:" + pyear);
                Console.WriteLine("Current year:" + nyear);
                //Console.WriteLine(year);
                var month = $"{num[i + 19]}{num[i + 20]}";
                mn = Convert.ToInt32(month);
                Console.WriteLine("Given month:" + mn);
                var day = $"{ num[i + 22]}{num[i + 23]}";
                Console.WriteLine("Given day:" + day);
                int dd = Convert.ToInt32(day);
                if (dd > 32)
                {
                    Console.WriteLine("invalid date");
                    break;
                }
                if (mn != 0 && mn <= 12)
                {

                }
                else
                {
                    Console.WriteLine("\n Invalid Month.\n Month value should be in [1-12]");

                }
                if (mn == 2)
                {
                    if (dd != 0 && dd > 28)
                    {
                        Console.WriteLine("\n Invalid date.\n Month feb has 28 days only");
                    }
                    else
                    {

                    }
                }
                else if (mn == 1 && mn == 3 && mn == 5 && mn == 7 && mn == 8 && mn == 10 && mn == 12)
                {
                    if (dd == 0 && dd <= 31)
                    {
                    }
                    else
                    {
                        Console.WriteLine("\n Invalid date.");
                    }
                }
                else if (mn == 4 && mn == 6 && mn == 9 && mn == 11)
                {
                    if (dd == 0 && dd <= 30) { }

                    else { Console.WriteLine("\n Invalid date."); }
                }

                if (mn == 1 && mn == 2 && mn == 3)
                {
                    var a = pyr - 1;
                    Console.WriteLine("\nStart year:" + a);
                    Console.WriteLine("End Year:" + nyr);
                }
                else
                {
                    var b = nyr + 1;
                    Console.WriteLine("\nStart year:"+pyr);
                    Console.WriteLine("End year:" + b);
                }
            }
           
           
        }

    }
}
