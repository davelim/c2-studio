using Helpers;

// Area, circumference, diameter
Console.WriteLine("Enter a radius: ");
string? input;
double radius;
while (true) {
    input = Console.ReadLine();
    if (!double.TryParse(input, out radius)) {
        Console.WriteLine("Sorry, please try again with a number.");
        //return;
        Environment.Exit(0);
    }
    if (radius > 0) {
        break;
    } else {
        Console.WriteLine("Please enter a positive number.");
    }
}

double area = Circle.Area(radius);
double circumference = Circle.Circumference(radius);
double diameter = Circle.Diameter(radius);
Console.WriteLine("For a circle of radius " + radius + "...");
Console.WriteLine("- area: " + area);
Console.WriteLine("- circumference: " + circumference);
Console.WriteLine("- diameter: " + diameter);

// Road Trip!
Console.WriteLine("Enter MPH: ");
input = Console.ReadLine();
double MPG = double.Parse(input);
double numberOfGallons = circumference / MPG;
Console.WriteLine("Gallons needed to go around circie: " + numberOfGallons);