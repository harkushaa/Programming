namespace LR5
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			List<Resident> residents = new List<Resident>()
			{
				new Resident("Green", new List<Service>()
				{
					new Service("Heating", new Tariff(TariffType.Standart, 5)),
					new Service("Electricity", new Tariff(TariffType.Preferential, 10)),
					new Service("Water Supply", new Tariff(TariffType.Standart, 10)),
					new Service("Maintenance", new Tariff(TariffType.Special, 20))
				}),
				new Resident("Smith", new List<Service>()
				{
					new Service("Heating", new Tariff(TariffType.Standart, 5)),
					new Service("Electricity", new Tariff(TariffType.Preferential, 10)),
					new Service("Water Supply", new Tariff(TariffType.Standart, 15))
				}),
				new Resident("Brown", new List<Service>()
				{
					new Service("Heating", new Tariff(TariffType.Standart, 5)),
					new Service("Electricity", new Tariff(TariffType.Standart, 10)),
					new Service("Water Supply", new Tariff(TariffType.Standart, 10)),
					new Service("Maintenance", new Tariff(TariffType.Special, 20))
				}),
				new Resident("White", new List<Service>()
				{
					new Service("Heating", new Tariff(TariffType.Preferential, 5)),
					new Service("Electricity", new Tariff(TariffType.Preferential, 10)),
					new Service("Water Supply", new Tariff(TariffType.Standart, 10))
				}),
				new Resident("Pinkman", new List<Service>()
				{
					new Service("Heating", new Tariff(TariffType.Standart, 5)),
					new Service("Electricity", new Tariff(TariffType.Preferential, 15)),
					new Service("Water Supply", new Tariff(TariffType.Standart, 10)),
					new Service("Maintenance", new Tariff(TariffType.Special, 20))
				})
			};
			while (true)
			{
				Console.Write("# ");
				switch (Console.ReadLine()!.Trim().ToLower())
				{
					case "add":
						Add(residents);
						break;
					case "search":
						Search(residents);
						break;
					case "print":
						Print(residents);
						break;
				}
			}
		}
	
		private static void Add(List<Resident> residents)
		{
			Console.Write("Name: ");
			Resident resident = new Resident(Console.ReadLine()!.Trim());
			Console.Write("Services count: ");
			int n = int.Parse(Console.ReadLine()!.Trim());
			for (int i = 0; i < n; i++)
			{
				Console.Write("\tService name: ");
				string serviceName = Console.ReadLine()!.Trim();
				TariffType tariffType = TariffType.Standart;
				Console.Write("\t\tTariff type: ");
				switch (Console.ReadLine()!.Trim().ToLower())
				{
					case "st":
						tariffType = TariffType.Standart;
						break;
					case "p":
						tariffType = TariffType.Preferential;
						break;
					case "sp":
						tariffType = TariffType.Special;
						break;
				}
				Console.Write("\t\tTariff price: ");
				decimal price = decimal.Parse(Console.ReadLine()!.Trim());
				resident.AddService(new Service(serviceName, new Tariff(tariffType, price)));
			}
			residents.Add(resident);
		}

		private static void Search(List<Resident> residents)
		{
			Console.Write("Prompt: ");
			string prompt = Console.ReadLine()!.Trim().ToLower();
			foreach (var resident in residents)
			{
				if (resident.Name.ToLower().Contains(prompt))
					Console.WriteLine(resident);
			}
		}

		private static void Print(List<Resident> residents)
		{
			decimal cost = 0;
			foreach (var resident in residents)
			{
				cost += resident.GetCost();
				Console.WriteLine(resident);
			}
			Console.WriteLine($"All cost: {cost}");
		}
	}
}