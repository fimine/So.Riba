using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossOver.RIBA.Data.Contexts
{
    public interface ICrossOverContext 
    {
		 DbSet<Models.User> Users { get; set; }
		 DbSet<Models.TestExam> TestExams { get; set; }
		 DbSet<Models.Question> Questions { get; set; }
		 DbSet<Models.QuestionChoiceAnswer> QuestionChoiceAnswers { get; set; }
		 DbSet<Models.UserExam> UserExams { get; set; }
	}
}
