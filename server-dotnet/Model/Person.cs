using server_lib;

namespace server_dotnet
{
    public class Person : AuditableEntity
    {
        public string Name { get; set; } = string.Empty;

        public string? Title { get; set; }

        public Address? Address { get; set; } = null;

    }
}
