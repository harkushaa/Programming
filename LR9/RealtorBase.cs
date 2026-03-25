namespace LR9
{
    abstract class RealtorBase
    {
        protected IObject? _obj;

        public abstract string Name { get; set; }

        public void SetObject(IObject obj) =>
            _obj = obj;

        public void DescribeObject() =>
            Console.WriteLine($"Object is {(_obj is null ? "null" : _obj.Description())}");

        public abstract void GetInfo();
    }
}
