using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CrossOver.RIBA.Data.Models
{
   public  class UserExam : BaseModel
    {
		[Key]
		public long ID { get; set; }

		[ForeignKey("FK_User")]
		public User User { get; set; }
		[ForeignKey("FK_TestExam")]
		public TestExam TestExam { get; set; }
    }
}
