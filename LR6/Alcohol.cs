namespace LR6
{
    abstract class Alcohol
    {
        protected int _concentration;
        protected int _volume;
        protected string? _preparationMethod;
        protected string? _raw;
        protected int _agingYear;

        public Alcohol()
        {
            _concentration = 0;
            _volume = 100;
            _agingYear = new Random().Next(1900, 2000);
			Console.WriteLine("Alcohol was born");
        }

        public void Drink(int volume)
        {
            _volume = (_volume - volume) > 0 ? _volume - volume : 0;
            Console.WriteLine($"Drink {volume} units of alcohol");
        }

        public virtual void Aging()
        {
			Console.WriteLine($"This is {DateTime.Now.Year - _agingYear} year old alcohol, Sir");
        }

        public abstract void Cook();
    }
}
