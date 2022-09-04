//this program prints the next 20 leap years from 2022

using System;

class LeapYearAnnouncer {
	static int currentYear = 2022;
    
	public static void PrintLeapYears()
	{
		for (int y = currentYear; y <= 2104; y++)
		{
			if (DateTime.IsLeapYear(y))
			{
				Console.WriteLine($"{y} is a leap year");
			}
		}
	}
}
