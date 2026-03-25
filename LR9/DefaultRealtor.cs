namespace LR9
{
	class DefaultRealtor(string _name) : RealtorBase, IPreparation, IVisit
	{
		public override string Name { get => _name; set => _name = value; }

		public override void GetInfo() =>
			Console.WriteLine($"I'm a Default Realtor, my name is {_name}");

		public void Preparation() =>
			Console.WriteLine("Registration of documents");

		public void Visit() =>
			Console.WriteLine($"Visit to the {(_obj is null ? "null" : _obj.Description())}");
	}
}