namespace LR9
{
    static class Agency
    {
        /// <summary>
        /// Creates realtor without object
        /// </summary>
        /// <param name="name">Name of realtor</param>
        /// <param name="builder">Realtor builder</param>
        /// <returns>Instance of realtor</returns>
        public static RealtorBase GetRealtor(string name, Builder builder) =>
            builder.SetName(name).Build();

		/// <summary>
		/// Creates realtor with Apartament object
		/// </summary>
		/// <param name="name">Name of realtor</param>
		/// <param name="builder">Realtor builder</param>
		/// <returns>Instance of realtor</returns>
		public static RealtorBase GetApartmentRealtor(string name, Builder builder) =>
            builder
			.SetName(name)
			.SetObject(new Apartment())
			.Build();

		/// <summary>
		/// Creates realtor with Car object
		/// </summary>
		/// <param name="name">Name of realtor</param>
		/// <param name="builder">Realtor builder</param>
		/// <returns>Instance of realtor</returns>
		public static RealtorBase GetCarRealtor(string name, Builder builder) =>
            builder.SetName(name).SetObject(new Car()).Build();

		/// <summary>
		/// Creates realtor with Promise :)
		/// </summary>
		/// <param name="name">Name of realtor</param>
		/// <param name="builder">Realtor builder</param>
		/// <returns>Instance of realtor</returns>
		public static RealtorBase GetPromiseRealtor(string name, Builder builder) =>
            builder.SetName(name).SetObject(new Promise()).Build();
    }
}
