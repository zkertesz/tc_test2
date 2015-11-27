using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cutoffTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Pacific Standard Time").Date;


            var cutoffTime2 = DateTime.UtcNow.Date;

            Console.WriteLine(DateTime.UtcNow.ToString());
            Console.WriteLine(cutoffTime + " " + (cutoffTime-DateTime.UtcNow).TotalHours);
            Console.WriteLine(cutoffTime.ToUniversalTime().ToString());
            Console.WriteLine(cutoffTime2 + " " + (cutoffTime2 - DateTime.UtcNow).TotalHours);
            Console.WriteLine(cutoffTime2.ToUniversalTime().ToString());
            Console.Read();
            var date1 = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Mountain Standard Time").Date.ToUniversalTime();
            var date2 = DateTime.UtcNow.Date;
        }
    }
}
