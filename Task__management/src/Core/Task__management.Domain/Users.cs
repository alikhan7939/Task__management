using System.ComponentModel.DataAnnotations;
using Task__management.Domain.Common;

namespace Task__management.Domain
{
	public class Users : BaseDomainEntity
	{
        [Required]
		public string Name { get; set; } = default!;
        [Required]
        public string Email { get; set; } = default!;
        [Required]
        public string Password { get; set; } = default!;
        [Required]
        public int PhonNumber { get; set; }
        [Required]
        public List<string> Grade { get; set; } = default!;
        [Required]
        public string Address { get; set; } = default!;
		public DateTime Joined { get; set; }
        
       

    }
}
