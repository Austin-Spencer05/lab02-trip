Console.WriteLine("== Road Trip ==");
Console.WriteLine("What was the round trip in miles?");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the miles per gallon of the car you are using?");
int carMilesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What was the gas price?");
double gasPrice = Convert.ToDouble(Console.ReadLine());

//do the math
double gallonsNeeded = milesForTheTrip / (double)carMilesPerGallon;
double fuelCost = gallonsNeeded * gasPrice;

//Do Output
System.Console.WriteLine("Gallons needed: "+gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel cost: "+fuelCost.ToString("C2"));

