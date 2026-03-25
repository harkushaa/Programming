namespace LR3.Services
{
	internal class Task2
	{
		public static void F(double z, double n, double k, double m)
		{
			double x;
			if (z > 1) 
			{
                Console.WriteLine("Branch 1: e^z + z : z > 1");
				x = Math.Pow(Math.E, z);
            }
			else
			{
                Console.WriteLine("Branch 2: z^2 + 1 : z <= 1");
				x = z * z + 1;
            }
            Console.WriteLine($"Result: {Math.Sin(n * x) + Math.Cos(k * x) + Math.Log(m * x)}");
        }
	}
}
