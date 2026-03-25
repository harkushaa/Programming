namespace LR8
{
    class Resident
    {
        private string _name;
        private IPrivilege _privilege;
        private List<Service> _services;

        public string Name { get => _name; }
        public IPrivilege Privilege { set => _privilege = value; }

        public Resident(string name)
        {
            _name = name;
            _privilege = new ZeroPrivilege();
            _services = new List<Service>();
        }

        public Resident(string name, IPrivilege privilege)
        {
            _name = name;
            _privilege = privilege;
            _services = new List<Service>();
        }

		public Resident(string name, List<Service> services)
		{
			_name = name;
            _privilege = new ZeroPrivilege();
			_services = services;
		}

		public Resident(string name, IPrivilege privilege, List<Service> services)
        {
            _name = name;
            _privilege = privilege;
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
                cost += service.Price;
			}
            return (cost - _privilege.GetDiscount()) > 0 ? cost - _privilege.GetDiscount() : 0;
		}

		public override string? ToString()
		{
            string result = $"{_name}\n";
            foreach (var service in _services)
                result += service + "\n";
            result += $"\tCost: \t\t{GetCost()} \n\tDiscount: \t{_privilege.GetDiscount()}";
			return result;
		}
	}
}
