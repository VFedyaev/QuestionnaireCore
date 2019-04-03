using Microsoft.EntityFrameworkCore;
using QuestionnaireCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Data
{
    public class QuestionnaireCoreContext : DbContext
    {
        public DbSet<QuestionType> QuestionTypes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        public DbSet<SurveyGeography> SurveyGeographies { get; set; }
        public DbSet<HousingType> HousingTypes { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Interviewer> Interviewers { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<QuestionnaireCore.Data.Entities.Data> Datas { get; set; }

        public QuestionnaireCoreContext(DbContextOptions<QuestionnaireCoreContext> options) 
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Question>()
                .HasIndex(q => new { q.Name}).IsUnique();
            builder.Entity<Answer>()
                .HasIndex(a => new { a.Name }).IsUnique();
        }
    }
}
