namespace LR8
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			List<Resident> residents = new List<Resident>()
			{
				new Resident("Brown", new ZeroPrivilege(), new List<Service>()
				{
					new Service("Heating", 150),
					new Service("Electricity", 100),
					new Service("Water Supply", 200),
					new Service("Maintenance", 100)
				}),
				new Resident("White", new StandartPrivilege(200), new List<Service>()
				{
					new Service("Heating", 50),
					new Service("Electricity", 100),
					new Service("Water Supply", 100)
				}),
				new Resident("Pinkman", new StandartPrivilege(100), new List<Service>()
				{
					new Service("Heating", 50),
					new Service("Electricity", 150),
					new Service("Water Supply", 100),
					new Service("Maintenance", 200)
				})
			};
			HousingService housingService = new(residents);
			housingService.AddStandartPrivilegeResident(new Resident("Green", new List<Service>()
				{
					new Service("Heating", 100),
					new Service("Electricity", 100),
					new Service("Water Supply", 150),
					new Service("Maintenance", 200)
				}),
				new StandartPrivilege(50));
			housingService.AddZeroPrivilegeResident(new Resident("Smith", new List<Service>()
				{
					new Service("Heating", 50),
					new Service("Electricity", 100),
					new Service("Water Supply", 150)
				}));
			housingService.PrintResidents();
			Console.WriteLine($"\nTotal cost: \t\t{housingService.GetTotalCost()}");
		}
	}
}