namespace LR5
{
    class Resident
    {
        private string _name;
        private List<Service> _services;

        public string Name { get => _name; }

		public Resident(string name)
        {
            _name = name;
            _services = new List<Service>();
        }

        public Resident(string name, List<Service> services)
        {
            _name = name;
            _services = services;
        }

        public void AddService(Service service)
        {
            _services.Add(service);
        }


        public decimal GetCost()
        {
            decimal cost = 0;
			foreach (var service in _services)
			{
                cost += service.Tariff.GetCost();
			}
            return cost;
		}

		public override string? ToString()
		{
            string result = $"{_name}\n";
            foreach (var service in _services)
                result += service + "\n";
            result += $"\tCoast: {GetCost()}";
			return result;
		}
	}
}