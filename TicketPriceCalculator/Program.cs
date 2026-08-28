using System;

const int childAgeLimit = 12;
const int seniorAgeLimit = 65;
const int childAndSeniorTicketPrice = 7;
const int normalTicketPrice = 10;

Console.Write("Enter your age: ");
string? input = Console.ReadLine();

if (!int.TryParse(input, out int age))
{
    Console.WriteLine("Invalid input. Please enter a valid whole number for age.");
}
else if (age < 0)
{
    Console.WriteLine("Invalid age. Age cannot be negative.");
}
else
{
    int ticketPrice;

    if (age <= childAgeLimit)
    {
        ticketPrice = childAndSeniorTicketPrice;
    }
    else if (age >= seniorAgeLimit)
    {
        ticketPrice = childAndSeniorTicketPrice;
    }
    else
    {
        ticketPrice = normalTicketPrice;
    }

    Console.WriteLine($"Ticket Price: GHC{ticketPrice}");
}
