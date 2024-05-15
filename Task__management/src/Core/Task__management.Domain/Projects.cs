using Task__management.Domain.Common;

namespace Task__management.Domain
{
	public class Projects : BaseDomainEntity
    {
        public string ProjectName { get; set; } = default!;
        public string ProjectType { get; set; } = default!;
        public DateTime DeliveryTime { get; set; }

    }
} 
