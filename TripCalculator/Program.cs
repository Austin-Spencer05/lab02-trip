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

//Next Part
Console.WriteLine("Food Cost");
Console.WriteLine("How many people are going?");
int people = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many pizzas?");
int pizzas = Convert.ToInt32(Console.ReadLine());
const int slices = 8;
Console.WriteLine("How much does a pizza cost?");
double pizzaCost = Convert.ToDouble(Console.ReadLine());
//Math Pt 2.
double totalslices = pizzas * slices;

double sliceperpers = totalslices / people;

double pizzaCosttotal= pizzas * pizzaCost;
//print screen
System.Console.WriteLine("Total slices: " + totalslices.ToString("F2"));

System.Console.WriteLine("Slices per person: " + sliceperpers.ToString("F2"));

System.Console.WriteLine("Pizza Cost: " +pizzaCosttotal.ToString("C2"));

//Cost control
Console.WriteLine("Paycheck");
Console.WriteLine("Hours Worked this week?");
int hours = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Hourly Pay?");
double pay = Convert.ToDouble(Console.ReadLine());
const double taxes = 0.18;
//Math Pt 3
double grosspay = hours * pay;

double withheld = grosspay * taxes;

double takehome = grosspay - withheld;
//Printscreen
System.Console.WriteLine("Gross pay: " +grosspay.ToString("C2"));
System.Console.WriteLine("Tax withheld : " +withheld.ToString("C2"));
System.Console.WriteLine("Take home pay: " +takehome.ToString("C2"));
// Whole Trip
double triptot = fuelCost + pizzaCosttotal;
double costperpers = triptot + people;
double takehomephr = takehome / hours;
double hltw = costperpers / takehomephr;
//Print last section
Console.WriteLine("Totals");
System.Console.WriteLine("Trip total: " + triptot.ToString("C2"));

System.Console.WriteLine("Cost Per Person: " + costperpers.ToString("C2"));

System.Console.WriteLine("Take Home Pay Per Hour: " + takehomephr.ToString("C2"));

System.Console.WriteLine("Hours to work to cover your share: " + hltw.ToString("f2"));