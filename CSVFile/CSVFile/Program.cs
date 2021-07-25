using System;
using System.Collections.Generic;
using System.IO;

namespace CSVFile
{
    class Program
    {
        /*Create a Console application that will read (File.ReadAllLines) in the sales_data_sample.csv.
         * We want to sum up all of the sales with the status of Shipped and output the total sales by year 
         * (e.g. how much did we sell in 2003, 2004, 2005) as well as total sales by month across all years 
         * (e.g. how much did we sell in January of 2003/2004/2005 and February of 2003/2004/2005 etc.), make 
         * sure to output it as January/February etc and not 1/2.
         */
        static void Main(string[] args)
        {
            string file = "sales_data_sample.csv";

            string[] contents = File.ReadAllLines(file);

            double salesfor2003 = 0;
            double salesfor2004 = 0;
            double salesfor2005 = 0;
            double[] sumOfMonths = new double[13];
            sumOfMonths[0] = 0;
            sumOfMonths[1] = 0;
            sumOfMonths[2] = 0;
            sumOfMonths[3] = 0;
            sumOfMonths[4] = 0;
            sumOfMonths[5] = 0;
            sumOfMonths[6] = 0;
            sumOfMonths[7] = 0;
            sumOfMonths[8] = 0;
            sumOfMonths[9] = 0;
            sumOfMonths[10] = 0;
            sumOfMonths[11] = 0;
            sumOfMonths[12] = 0;

            for (int i = 1; i < contents.Length; i++)
            {
                string line = contents[i];
                string[] pieces = line.Split(',');
                string status = pieces[6];

                double sale = Convert.ToDouble(pieces[4]);
                int year = Convert.ToInt32(pieces[9]);
                int month = Convert.ToInt32(pieces[8]);

                if (status.ToLower() == "shipped")
                {
                    sumOfMonths[month] += salesfor2003;
                    if (year == 2003)
                    {
                        salesfor2003 += sale;
                    }
                    else if (year == 2004)
                    {
                        salesfor2004 += sale;
                    }
                    else if (year == 2005)
                    {
                        salesfor2005 += sale;
                    }
                    else
                    {
                        Console.WriteLine($"Error: No year for {year}.");
                    }
                }
            }

            Console.WriteLine($"2003 = {salesfor2003.ToString("C")}");
            Console.WriteLine($"2004 = {salesfor2004.ToString("C")}");
            Console.WriteLine($"2005 = {salesfor2005.ToString("C")}");
            
            

            for (int i = 1; i < sumOfMonths.Length; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine($"Your total sales for January 2003 is {sumOfMonths[i].ToString("C")}.");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"Your total sales for February 2003 is {sumOfMonths[i].ToString("C")}.");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"Your total sales for March 2003 is {sumOfMonths[i].ToString("C")}.");
                }
                else if (i == 4)
                {
                    Console.WriteLine($"Your total sales for April 2003 is {sumOfMonths[i].ToString("C")}.");
                }
                else if (i == 5)
                {
                    Console.WriteLine($"Your total sales for May 2003 is {sumOfMonths[i].ToString("C")}.");
                }
                else if (i == 6)
                {
                    Console.WriteLine($"Your total sales for June 2003 is {sumOfMonths[i].ToString("C")}.");
                }
                else if (i == 7)
                {
                    Console.WriteLine($"Your total sales for July 2003 is {sumOfMonths[i].ToString("C")}.");
                }
                else if (i == 8)
                {
                    Console.WriteLine($"Your total sales for August 2003 is {sumOfMonths[i].ToString("C")}.");
                }
                else if (i == 9)
                {
                    Console.WriteLine($"Your total sales for September 2003 is {sumOfMonths[i].ToString("C")}.");
                }
                else if (i == 10)
                {
                    Console.WriteLine($"Your total sales for October 2003 is {sumOfMonths[i].ToString("C")}.");
                }
                else if (i == 11)
                {
                    Console.WriteLine($"Your total sales for November 2003 is {sumOfMonths[i].ToString("C")}.");
                }
                else
                {
                    Console.WriteLine($"Your total sales for December 2003 is {sumOfMonths[i].ToString("C")}.");
                }

            }
            
        }
    }
}
