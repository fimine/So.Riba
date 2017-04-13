using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CrossOver.RIBA.Data.Models
{
	public class QuestionChoiceAnswer : BaseModel
	{
		[Key]
		public long ID { get; set; }
		[Required]
		public string AnswerChoiceText { get; set; }
		[Required]
		public int DisplayOrder { get; set; }
		[Required]
		public bool IsCorrectChoice { get; set; }
	}
}
