using System;




class Program
{
    static void Main(string[] args)
    {
        double amount;
        double USD = 1.39;
        double GBP = .82;
        /*double CHF = 1.22;
        double AUD = 1.48;
        double CAD = 1.51;*/
        string currency;

        Console.WriteLine("Please enter the amount of Euro you wish to be converted:");
        amount = double.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Please choose the currency you wish to convert to:");
        Console.WriteLine("USD");
        Console.WriteLine("GBP");
        Console.WriteLine("CHF");
        Console.WriteLine("AUD");
        Console.WriteLine("CAD");
        Console.WriteLine("");
        currency = Console.ReadLine();

        switch (currency)
        {
            case "USD":
                Console.WriteLine("You have entered {0} EUR which converts to {1} {2}", amount, amount * currency, currency);
                break;
            case "GBP":

            default:
                Console.WriteLine("You did not enter a valid currency");
                break;
        }
        Console.ReadLine();


    }
}

