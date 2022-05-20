namespace server_dotnet
{
    public class Person
    {
        public string Name { get; set; } = string.Empty;

        public string? Title { get; set; }

        public Address? Address { get; set; } = null;

    }
}
