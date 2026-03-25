using System.ComponentModel;

namespace LR4
{
	internal class Tariff
	{
		private static decimal defaultPayPerMonth = 10;
		private decimal payPerMonth;

		public Tariff()
		{
			payPerMonth = defaultPayPerMonth;
		}

		public Tariff(decimal payPerMonth)
		{
			this.payPerMonth = payPerMonth;
		}

		public decimal PayPerMonth { get => payPerMonth; }

		public static void SetDefaultPayPerMonth(decimal payPerMonth)
		{
			defaultPayPerMonth = payPerMonth;
		}
	}
}
