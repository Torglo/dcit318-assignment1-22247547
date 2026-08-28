using System;

Console.Write("Enter the first side: ");
string? side1Input = Console.ReadLine();

Console.Write("Enter the second side: ");
string? side2Input = Console.ReadLine();

Console.Write("Enter the third side: ");
string? side3Input = Console.ReadLine();

if (!double.TryParse(side1Input, out double side1) ||
    !double.TryParse(side2Input, out double side2) ||
    !double.TryParse(side3Input, out double side3))
{
    Console.WriteLine("Invalid input. Please enter valid numbers for all three sides.");
}
else if (side1 <= 0 || side2 <= 0 || side3 <= 0)
{
    Console.WriteLine("Invalid triangle. All sides must be greater than 0.");
}
else if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
{
    Console.WriteLine("Invalid triangle. The side lengths do not satisfy the triangle inequality.");
}
else
{
    string triangleType;

    if (side1 == side2 && side2 == side3)
    {
        triangleType = "Equilateral";
    }
    else if (side1 == side2 || side1 == side3 || side2 == side3)
    {
        triangleType = "Isosceles";
    }
    else
    {
        triangleType = "Scalene";
    }

    Console.WriteLine($"Triangle Type: {triangleType}");
}
