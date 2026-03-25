namespace LR9
{
	class BlackRealtorBuilder : Builder
	{
		public override RealtorBase Build()
		{
			BlackRealtor realtor = new(_name);
			if (_obj != null)
				realtor.SetObject(_obj);
			else
				realtor.SetObject(new Promise());
			return realtor;
		}
	}
}
