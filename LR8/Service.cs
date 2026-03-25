namespace LR8
{
    class Service(string _name, decimal _price)
    {
        public string Name { get => _name; }
        public decimal Price { get => _price; }

		public override string? ToString() =>
			$"\t{_name} \t{_price}";
	}
}