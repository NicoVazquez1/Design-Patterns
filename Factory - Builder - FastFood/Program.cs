// See https://aka.ms/new-console-template for more information
using Factory___Builder___FastFood.ChocolateBarFactories;
using Factory___Builder___FastFood.ChocolateBars;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

IChocolateBarFactory? SelectChocolateFactory()
{
    Console.WriteLine("Escoje el tipo de chocolate a fabricar");
    Console.WriteLine("\n 1. Chocolates de leche \n 2. Chocolates negros \n 3. Chocolate blanco ");
    char selection = Console.ReadKey().KeyChar;
    if (selection == '1') return new MilkChocolateBarFactory();
    else if (selection == '2') return new DarkChocolateBarFactory();
    else if (selection == '3') return new WhiteChocolateBarFactory();
    else return null;
}

List<ChocolateBar> SelectChocolatesCreationByQuantity(IChocolateBarFactory chocolateFactory)
{
    List<ChocolateBar> chocolates = new List<ChocolateBar>();
    int quantityNumber = 0;
    while (quantityNumber == 0) {
        Console.WriteLine("\nPor favor, Escoje la cantidad de chocolates a fabricar, el valor no puede ser 0");
        quantityNumber = int.Parse(Console.ReadLine());
    } 
    for (int i = 0; i < quantityNumber; i++) chocolates.Add(chocolateFactory.CreateChocolateBar());
    return chocolates;
}

void DisplayChocolateMenuOption()
{
    List<ChocolateBar> chocolates = new List<ChocolateBar>();
    IChocolateBarFactory? factory = null;
    while (factory == null) factory = SelectChocolateFactory();
    chocolates = SelectChocolatesCreationByQuantity(factory);
    Console.WriteLine($"\n Se crearon {chocolates.Count} chocolates del tipo {chocolates.First().Type} " );
    Console.WriteLine($"\n Se debe abonar {chocolates.Count * chocolates.First().Price}");
}

DisplayChocolateMenuOption();