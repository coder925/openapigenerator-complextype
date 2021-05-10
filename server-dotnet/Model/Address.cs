namespace server_dotnet
{
	public class Address
	{
		public Address(string Street1, string City)
		{
			this.Street1 = Street1;
			this.City = City;
		}

		public string Street1 { get; private set; } 
		public string City { get; private set;  }
	}
}