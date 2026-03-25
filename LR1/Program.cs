namespace LR1
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("Write first number: ");
			decimal a = decimal.Parse(Console.ReadLine() ?? "0");
			Console.Write("Write second number: ");
			decimal b = decimal.Parse(Console.ReadLine() ?? "0");
			decimal c = a / b;
			Console.WriteLine("Result: " + c);
		}
	}
}