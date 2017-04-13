using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CrossOver.RIBA.Data.Contexts;

namespace CrossOver.RIBA.Data.Migrations
{
    [DbContext(typeof(CrossOverContext))]
    partial class CrossOverContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrossOver.RIBA.Data.Models.Question", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Order");

                    b.Property<string>("ProblemDescription")
                        .IsRequired();

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<bool>("isMultipleAnswersPossible");

                    b.HasKey("ID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("CrossOver.RIBA.Data.Models.QuestionChoiceAnswer", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnswerChoiceText")
                        .IsRequired();

                    b.Property<int>("DisplayOrder");

                    b.Property<bool>("IsCorrectChoice");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("ID");

                    b.ToTable("QuestionChoiceAnswers");
                });

            modelBuilder.Entity("CrossOver.RIBA.Data.Models.TestExam", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("PassScore");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("TestExams");
                });

            modelBuilder.Entity("CrossOver.RIBA.Data.Models.User", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CrossOver.RIBA.Data.Models.UserExam", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("FK_TestExam");

                    b.Property<long?>("FK_User");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("ID");

                    b.HasIndex("FK_TestExam");

                    b.HasIndex("FK_User");

                    b.ToTable("UserExams");
                });

            modelBuilder.Entity("CrossOver.RIBA.Data.Models.UserExam", b =>
                {
                    b.HasOne("CrossOver.RIBA.Data.Models.TestExam", "TestExam")
                        .WithMany()
                        .HasForeignKey("FK_TestExam");

                    b.HasOne("CrossOver.RIBA.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("FK_User");
                });
        }
    }
}
