using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CrossOver.RIBA.Data.Models
{
	public class TestExam : BaseModel
	{
		[Key]
		public long ID { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public int PassScore { get; set; }
		public int TotalScore { get; set; }
    }
}
