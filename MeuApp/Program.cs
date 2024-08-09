﻿using System;
using System.Globalization;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var utcDate = DateTime.UtcNow;

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(utcDate);

            Console.WriteLine(utcDate.ToLocalTime());

            var horaAustralia =
            TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(horaAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("_________");
            }
        }
    }
}