namespace LR8
{
    class StandartPrivilege(decimal _rate) : IPrivilege
    {
        private static readonly decimal _percent = 0.1M;

        public decimal GetDiscount() =>
            _rate * (1 + _percent);
    }
}
