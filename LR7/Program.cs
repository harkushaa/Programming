using LR7;

internal class Programm
{
	private static void Main(string[] args)
	{
		Interval firstInterval = new Interval(1, 4);
		Interval secondInterval = new Interval(3, 8);
		Console.WriteLine($"first: {firstInterval}");
		Console.WriteLine($"second: {secondInterval}");
		Console.WriteLine($"first length: {firstInterval.GetLength()}");
		Console.WriteLine($"second length: {secondInterval.GetLength()}");
		Console.WriteLine($"+: {firstInterval + secondInterval}");
		Console.WriteLine($"-: {firstInterval - secondInterval}");
		Console.WriteLine($"*: {firstInterval * secondInterval}");
		Console.WriteLine($"++: {firstInterval++}");
		Console.WriteLine($"--: {firstInterval--}");
		Console.WriteLine($">: {firstInterval > secondInterval}");
		Console.WriteLine($">=: {firstInterval >= secondInterval}");
		Console.WriteLine($"==: {firstInterval == secondInterval}");
		Console.WriteLine($"!=: {firstInterval != secondInterval}");
		Console.WriteLine($"<=: {firstInterval <= secondInterval}");
		Console.WriteLine($"<: {firstInterval < secondInterval}");
		Console.WriteLine($"true: {(firstInterval ? true : false)}");
		Console.WriteLine($"false: {(firstInterval ? false : true)}");
		Console.WriteLine($"double cast: {(double)firstInterval}");
		Console.WriteLine($"interval case: {(Interval)5.0}");
		Console.WriteLine($"[0]: {firstInterval[0]}");
		Console.WriteLine($"[1]: {firstInterval[1]}");
	}
}