using Task__management.Domain.Common;

namespace Task__management.Domain
{
	public class Tasks : BaseDomainEntity
	{
		public string TaskDefinition { get; set; } = default!;
		public string TaskName { get; set; }= default!;
		public string Description { get; set; } = default!;
        public Projects ProjectsName { get; set; }
    }
}
