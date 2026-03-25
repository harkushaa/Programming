namespace LR9
{
    abstract class Builder
    {
        protected string _name = String.Empty;
        protected IObject? _obj;

        public Builder SetName(string name)
        {
            _name = name;
            return this;
        }

        public Builder SetObject(IObject obj)
        {
            _obj = obj;
            return this;
        }

        public abstract RealtorBase Build();
    }
}
