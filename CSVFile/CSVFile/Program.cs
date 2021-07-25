using System;
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


            for (int i = 1; i < contents.Length; i++)
            {
                string line = contents[i];
                string[] pieces = line.Split(',');
                string status = pieces[9];

                double sale = Convert.ToDouble(pieces[4]);
                int year = Convert.ToInt32(pieces[9]);

                if (status.ToLower() == "shipped")
                {
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

            for (int i = 0; i < contents.Length; i++)
            {
                string line = contents[i];
                string

            }
            Console.WriteLine($"2003 = {salesfor2003}");
            Console.WriteLine($"2004 = {salesfor2004}");
            Console.WriteLine($"2005 = {salesfor2005}");
        }
    }
}
