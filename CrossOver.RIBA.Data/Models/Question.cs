using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CrossOver.RIBA.Data.Models
{
	public class Question : BaseModel
    {
		[Key]
		public long ID { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		public string ProblemDescription { get; set; }
		[Required]
		public bool isMultipleAnswersPossible { get; set; }
		[Required]
		public int Order { get; set; }
	}
}
