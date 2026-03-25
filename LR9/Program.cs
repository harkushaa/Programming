namespace LR9
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			DefaultRealtorBuilder defaultRealtorBuilder = new();
			BlackRealtorBuilder blackRealtorBuider = new();

			List<RealtorBase> realtors = new()
			{
				Agency.GetRealtor("Empy", defaultRealtorBuilder),
				Agency.GetApartmentRealtor("Apart", defaultRealtorBuilder),
				Agency.GetCarRealtor("Carry", defaultRealtorBuilder),
				Agency.GetApartmentRealtor("Nort", blackRealtorBuider),
				Agency.GetPromiseRealtor("Proms", blackRealtorBuider)
			};

			foreach(RealtorBase realtor in realtors)
			{
				realtor.GetInfo();
				realtor.DescribeObject();
				if (realtor is DefaultRealtor)
				{
					((DefaultRealtor)realtor).Preparation();
					((DefaultRealtor)realtor).Visit();
				}
				else if (realtor is BlackRealtor)
				{
					((BlackRealtor)realtor).Preparation();
					((BlackRealtor)realtor).CheckBanknotes();
				}
				Console.WriteLine(new String('-', 50));
			}
		}
	}
}