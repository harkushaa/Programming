namespace LR8
{
    class HousingService
    {
		private List<Resident> _residents;

		public HousingService() =>
			_residents = new List<Resident>();

		public HousingService(List<Resident> residents) =>
			_residents = residents;

		public void AddZeroPrivilegeResident(Resident resident)
		{
			resident.Privilege = new ZeroPrivilege();
			_residents.Add(resident);
		}

		public void AddStandartPrivilegeResident(Resident resident, StandartPrivilege privilege)
		{
			resident.Privilege = privilege;
			_residents.Add(resident);
		}
		
		public decimal GetTotalCost()
		{
			decimal cost = 0;
			foreach (var resident in _residents)
				cost += resident.GetCost();
			return cost;
		}

		public void PrintResidents()
		{
			foreach (var resident in _residents)
				Console.WriteLine($"{resident}\n");
		}
	}
}
