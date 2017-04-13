using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossOver.RIBA.Data.Contexts
{
	public class CrossOverContext : DbContext
	{

		public CrossOverContext(DbContextOptions<CrossOverContext> options) : base(options)
		{
			
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Models.User>()
				.HasIndex(p => p.UserName)
				.IsUnique();
				
				
		}

		public DbSet<Models.User> Users {get; set;}
		public DbSet<Models.TestExam> TestExams { get; set; }
		public DbSet<Models.Question> Questions { get; set; }
		public DbSet<Models.QuestionChoiceAnswer> QuestionChoiceAnswers { get; set; }
		public DbSet<Models.UserExam> UserExams { get; set; }

	}
}
