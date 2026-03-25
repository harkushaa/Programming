using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    class Service(string _name, Tariff _tariff)
    {
        public string Name { get => _name; }
        public Tariff Tariff { get => _tariff; }

		public override string? ToString()
		{
			return $"\t{_name} \t{_tariff}";
		}
	}
}
