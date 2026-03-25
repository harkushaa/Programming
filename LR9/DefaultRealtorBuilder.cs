namespace LR9
{
	class DefaultRealtorBuilder : Builder
	{
		public override RealtorBase Build()
		{
			DefaultRealtor realtor = new(_name);
			if (_obj != null)
				realtor.SetObject(_obj);
			return realtor;
		}
	}
}
