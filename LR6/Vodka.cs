namespace LR6
{
    class Vodka : Alcohol
    {
		public Vodka() : base() 
		{
			_agingYear = new Random().Next(2000, 2020);
			Console.WriteLine("Vodka was born");
		}

		public new void Drink(int volume)
		{
			_volume = (_volume - volume) > 0 ? _volume - volume : 0;
			Console.WriteLine($"Drink {volume} units of alcohol");
		}

		public override void Cook()
		{
			_raw = "Seed";
			_preparationMethod = "Fermentation";
			_concentration = new Random().Next(40, 95);
			Console.WriteLine($"Cooking vodka: {_concentration} concentration");
		}

		public override string? ToString()
		{
			return $"Vodka {"{"}concentration: {_concentration}, volume: {_volume}, preparation_method: {_preparationMethod}, raw: {_raw}, aging_year: {_agingYear}{"}"}";
		}
	}
}
