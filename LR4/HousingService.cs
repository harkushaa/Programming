namespace LR4
{
	internal class HousingService
	{
		private static HousingService? instance;
		private int id;
		private string? region;
		private int residentsCount;
		private Tariff? tariff;
		private int paidResidentsCount;

		private HousingService() { }

		private HousingService(string? region, int residentsCount, int paidResidentsCount)
		{
			id = 0;
			this.region = region;
			this.residentsCount = residentsCount;
			tariff = new Tariff();
			this.paidResidentsCount = paidResidentsCount;
		}

		private HousingService(int id, string? region, int residentsCount, Tariff? tariff, int paidResidentsCount)
		{
			this.id = id;
			this.region = region;
			this.residentsCount = residentsCount;
			this.tariff = tariff;
			this.paidResidentsCount = paidResidentsCount;
		}

		public int Id { get => id; set => id = value; }
		public string? Region { get => region; set => region = value; }
		public int ResidentsCount { get => residentsCount; set => residentsCount = value; }
		public int PaidResidentsCount { get => paidResidentsCount; set => paidResidentsCount = value; }
		internal Tariff? Tariff { get => tariff; set => tariff = value; }

		public static HousingService GetInstance()
		{
			if (instance == null)
				instance = new HousingService();
			return instance;
		}

		public static HousingService GetInstance(int id, string? region, int residentsCount, Tariff? tariff, int paidResidentsCount)
		{
			if (instance == null)
				instance = new HousingService(id, region, residentsCount, tariff, paidResidentsCount);
			return instance;
		}

		public static HousingService GetInstance(string? region, int residentsCount, int paidResidentsCount)
		{	
			if (instance == null)
				instance = new HousingService(region, residentsCount, paidResidentsCount);
			return instance;
		}

		public decimal GetTotalDebt()
		{
			return (residentsCount - paidResidentsCount) * tariff!.PayPerMonth;
		}

		public void ChangeTariff(decimal newPayPerMonth)
		{
			tariff!.PayPerMonth = newPayPerMonth;				
		}
	}
}
