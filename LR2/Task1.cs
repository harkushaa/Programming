namespace LR2
{
	internal class Task1
	{
		public static void execute()
		{
			while (true)
			{
                Console.Write("Write number: ");
                string num = Console.ReadLine()!;
				if (num[0] > num[1])
					Console.WriteLine("First higher");
				else if (num[0] < num[1])
					Console.WriteLine("Second higher");
				else
					Console.WriteLine("Equals");
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
