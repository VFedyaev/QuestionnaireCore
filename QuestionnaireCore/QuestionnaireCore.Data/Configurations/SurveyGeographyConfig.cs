using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuestionnaireCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Data.Configurations
{
    public class SurveyGeographyConfig : IEntityTypeConfiguration<SurveyGeography>
    {
        public void Configure(EntityTypeBuilder<SurveyGeography> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.Name);
            builder.Property(e => e.Name).IsRequired();
        }
    }
}
