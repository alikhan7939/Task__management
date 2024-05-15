using Task__management.Domain.Common;

namespace Task__management.Domain
{
	public class Tasks : BaseDomainEntity
	{
        public string TaskName { get; set; }
        public string Description { get; set; }
        public Projects Project { get; set; }
        public DateTime TaskDelivery { get; set; }
    }
}
