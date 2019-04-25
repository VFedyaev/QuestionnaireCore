using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuestionnaireCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Data.Configurations
{
    public class InterviewerConfig : IEntityTypeConfiguration<Interviewer>
    {
        public void Configure(EntityTypeBuilder<Interviewer> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.Name);
            builder.Property(e => e.Name).IsRequired();
        }
    }
}
