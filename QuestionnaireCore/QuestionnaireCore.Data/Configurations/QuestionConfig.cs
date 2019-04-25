using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuestionnaireCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Data.Configurations
{
    class QuestionConfig : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.Name).IsUnique();
            builder.Property(e => e.Name).IsRequired();
        }
    }
}
