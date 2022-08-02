using CarDealerships.Parser;

Parser parser = new Parser();
foreach (var item in parser.GetCars())
{
    Console.WriteLine(item.Name);
}



