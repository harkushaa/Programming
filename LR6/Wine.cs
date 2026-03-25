namespace LR6
{
    sealed class Wine : Alcohol
    {
        public Wine() : base() 
        {
			Console.WriteLine("Wine was born");
		}
        
        public override void Cook()
        {
            _raw = "Grape";
            _preparationMethod = "Fermentation";
            _concentration = new Random().Next(11, 13);
			Console.WriteLine($"Cooking wine: {_concentration} concentration");
		}

		public override void Aging()
		{
			Console.WriteLine($"This is {DateTime.Now.Year - _agingYear} year old wine, Sir");
		}

		public override string? ToString()
		{
			return $"Wine {"{"}concentration: {_concentration}, volume: {_volume}, preparation_method: {_preparationMethod}, raw: {_raw}, aging_year: {_agingYear}{"}"}";
		}
	}
}
