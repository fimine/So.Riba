using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CrossOver.RIBA.Data.Models
{
	public class User : BaseModel
	{
		[Key]
		public long ID { get; set; }
		[Required]
		public string FullName { get; set; }
		[Required]
		public string UserName { get; set; }
		[Required]
		public string Password { get; set; }
    }
}
