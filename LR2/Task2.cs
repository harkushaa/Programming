namespace LR2
{
	internal class Task2
	{
		public static void execute()
		{
			while (true)
			{
				Console.Write("Write x: ");
				int x = int.Parse(Console.ReadLine()!);
				Console.Write("Write y: ");
				int y = int.Parse(Console.ReadLine()!);
				x = Math.Abs(x);
				y = Math.Abs(y);
				if (x == 40 && y <= 40 || x <= 40 && y == 40)
					Console.WriteLine("On board");
				else if (x <= 40 && y <= 40)
					Console.WriteLine("True");
				else
					Console.WriteLine("False");
				Console.Write("Continue? [y/N]: ");
				switch (Console.ReadLine()!.ToLower())
				{
					case "y":
						continue;
					default:
						return;
				}
			}
		}
	}
}
