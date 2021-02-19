using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var date = DateTime.Now;
                    var date1 = $"{date:d}";
                    var dat2 = "";
                    
                    var da2 = DateTime.Today.AddDays(-1);
                    var date2 = $"{da2:d}";
                    int mn = 0;
                    int pyr = 0;
                    int nyr = 0;
                    DayOfWeek wk = DateTime.Today.DayOfWeek;
                    Console.WriteLine("\nEnter the value");
                    var num = Console.ReadLine();
                    int l = num.Length;
                    string [] sp = num.Split("-");
                    var tex = "SO";
                    var text = "";
                    var inp = "-";
                    for (int i = 0; i < 1; i++)
                    {
                        //Input validation
                        // SO-2021-1234567890-12-21
                        text = $"{ num[i]}{num[i + 1]}";
                        var inp1 =$"{ num[i + 2]}";
                        var inp2 = $"{ num[i + 7]}";
                        var inp3 = $"{ num[i + 18]}";
                        var inp4 = $"{ num[i + 21]}";


                        if (num.Length == 24)
                        {
                        }
                        esle
                        {
                            Console.WriteLine("Invalid string lenth");
                            break;
                        }&& tex.Equals(text) && 
                            inp1.Equals(inp2).Equals(inp3).Equals(inp4).Equals(inp))
                        {
                        }
                        else
                        {
                            Console.WriteLine("Input format is invalid");
                            break;
                        }

                       // else if()
                        
                        var pyear = $"{num[i + 3]}{num[i + 4]}";
                        var nyear = $"{num[i + 5]}{num[i + 6]}";
                        pyr = Convert.ToInt32(nyear);
                        nyr = Convert.ToInt32(pyear);

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
                            break;

                        }
                        if (mn == 2)
                        {
                            if (dd != 0 && dd > 28)
                            {
                                Console.WriteLine("\n Invalid date.\n Month feb has 28 days only");
                                break;
                            }
                            else
                            {

                            }
                        }
                        if (mn == 1 && mn == 3 && mn == 5 && mn == 7 && mn == 8 && mn == 10 && mn == 12)
                        {
                            if (dd == 0 && dd <= 31)
                            {
                            }
                            else
                            {
                                Console.WriteLine("\n Invalid date.");
                                break;
                            }
                        }
                        if (mn == 4 && mn == 6 && mn == 9 && mn == 11)
                        {
                            if (dd == 0 && dd <= 30) { }

                            else { Console.WriteLine("\n Invalid date."); break; }

                        }

                        if (mn == 1 && mn == 2 && mn == 3)
                        {

                            var a = pyr - 1;
                            Console.WriteLine("\nStart year:" + a);
                            Console.WriteLine("End Year:" + nyr);
                        }
                        else
                        {
                            Console.WriteLine("\nCurrent year:" + pyr);
                            var b = nyr + 1;
                            Console.WriteLine("\nStart year:" + nyr);
                            Console.WriteLine("End year:" + b);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }

}

