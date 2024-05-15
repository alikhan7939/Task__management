using Task__management.Domain.Common;

namespace Task__management.Domain
{
	public class Users : BaseDomainEntity
	{

        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public List<string> Grade { get; set; } = new();
    }
}
