using Services.LR3;

namespace LR3
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("Task: [1-3] ");
			string task = Console.ReadLine()!.Trim();
			switch (task)
			{
				case "1":
					RunTask1();
					break;
				case "2":
					RunTask2();
					break;
				case "3":
					RunTask3();
					break;
				default:
                    Console.WriteLine($"Task \"{task}\" not found!");
					break;
            }
		}

		private static void RunTask1()
		{
			Console.Write("a: ");
			double a = Task1.F(double.Parse(Console.ReadLine()!));
			Console.Write("b: ");
			double b = Task1.F(double.Parse(Console.ReadLine()!));
			if (a == b)
				Console.WriteLine("a equals b");
			else if (a < b)
				Console.WriteLine("a is smaller");
			else
				Console.WriteLine("b is smaller");
        }

		private static void RunTask2()
		{
			Console.Write("z: ");
			double z = double.Parse(Console.ReadLine()!);
			Console.Write("n: ");
			double n = double.Parse(Console.ReadLine()!);
			Console.Write("k: ");
			double k = double.Parse(Console.ReadLine()!);
			Console.Write("m: ");
			double m = double.Parse(Console.ReadLine()!);
			Services.Task2.F(z, n, k, m);
		}

		private static void RunTask3()
		{
            Console.Write("1) Get day of week\n2) Get days span\nSelect mode: [1-2] ");
			string mode = Console.ReadLine()!.Trim();
			switch (mode)
			{
				case "1":
					Console.Write("Date: ");
					Console.WriteLine($"Result: {DateService.GetDay(Console.ReadLine()!)}");
					break;
				case "2":
					Console.Write("Day: ");
					int day = int.Parse(Console.ReadLine()!.Trim());
					Console.Write("Month: ");
					int month = int.Parse(Console.ReadLine()!.Trim());
					Console.Write("Year: ");
					int year = int.Parse(Console.ReadLine()!.Trim());
                    Console.WriteLine($"Result: {DateService.GetDaysSpan(day, month, year)}");
                    break;
				default:
					Console.WriteLine($"Mode \"{mode}\" not found!");
					break;
			}
        }
	}
}