using System.Xml.Linq;

namespace LR9
{
    class BlackRealtor(string _name) : RealtorBase, IPreparation, ICheck
	{
		public override string Name { get => _name; set => _name = value; }

		public override void GetInfo() =>
			Console.WriteLine($"I'm a Black Realtor, my name is {_name}");

		public void Preparation() =>
			Console.WriteLine("Forgery of documents");

		public void CheckBanknotes() =>
			Console.WriteLine("It seems like the money is real!");
	}
}
