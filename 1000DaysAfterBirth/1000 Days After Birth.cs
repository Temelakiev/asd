using System;

using System.Globalization;


class Program
{
    static void Main()
    {
        DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

        DateTime dateAfterThousandDays = birthDate.AddDays(999);

        Console.WriteLine("{0:dd-MM-yyyy}",dateAfterThousandDays);
     

    }
}

