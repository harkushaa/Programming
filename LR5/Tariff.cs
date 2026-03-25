namespace LR5
{
    class Tariff(TariffType _type = TariffType.Standart, decimal _price = 0)
    {
        public TariffType Type { get => _type; }
        public decimal Price { get => _price; }

        public decimal GetCost() => _type switch
        {

            TariffType.Preferential => _price * 0.9M,
            TariffType.Standart     => _price * 1.1M,
            TariffType.Special      => _price * 1.5M,
            _                       => _price

        };

		public override string? ToString()
		{
            return $"\t{_type} \t{_price}";
		}
	}
}
