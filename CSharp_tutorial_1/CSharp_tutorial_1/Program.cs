using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CSharp_tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////// tranforming strings into other types

            string str = ("true");
            string str1 = ("1000");
            bool boolFromStr = bool.Parse(str);
            int intFromStr = int.Parse(str1);
            Console.WriteLine(boolFromStr);
            Console.WriteLine(intFromStr);

            ///////////////////////////////////  DateTime

            DateTime awesomeDate = new DateTime(1996, 5, 18);
            Console.WriteLine("Day : {0}, Day of the year : {1}",awesomeDate.DayOfWeek,awesomeDate.DayOfYear);
            DateTime KasiasBday;
            KasiasBday = awesomeDate.AddYears(1);
            KasiasBday = KasiasBday.AddMonths(1);
            Console.WriteLine(KasiasBday.Date);

            ///////////////////////////////////Big Num

            BigInteger bigNum = BigInteger.Parse("123451234512345123451234512345123451234512345");
            Console.WriteLine("BigNum * 2 = {0}", bigNum * 2);

            //////////////////////////////// edytoweanie liczb?

            Console.WriteLine("Currency: {0:c}", 23.44242);
            Console.WriteLine("Pad with 0s: {0:d4}", 23);
            Console.WriteLine("3 Decimals: {0:f3}", 23.44272);
            Console.WriteLine("Commas: {0:n4}", 2344242);

            ////////////////////////////////!!!!!!!

            var intVal = 1234;
            Console.WriteLine("intVal type: {0}", intVal.GetType());

            Console.ReadLine();
        }
    }
}
