namespace server_dotnet
{
	public class Address
	{
		public Address(
			string Street1,
			string ZipCode,
			string City,
			string Country)
		{
			this.Street1 = Street1;
			this.ZipCode = ZipCode;
			this.City = City;
			this.Country = Country;
		}

		public string Street1 { get; }
		public string ZipCode { get; }
		public string City { get; }
		public string Country { get; }
	}
}