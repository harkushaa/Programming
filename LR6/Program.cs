using LR6;

internal class Program
{
	private static void Main(string[] args)
	{
		Wine wine = new Wine();
		wine.Cook();
		Console.WriteLine(wine);
		wine.Aging();
		wine.Drink(10);
		Console.WriteLine(wine);
		Vodka vodka = new Vodka();
		vodka.Cook();
		Console.WriteLine(vodka);
		vodka.Drink(40);
		vodka.Aging();
		Console.WriteLine(vodka);
	}
}