using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuestionnaireCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Data.Configurations
{
    public class DataConfig : IEntityTypeConfiguration<QuestionnaireCore.Data.Entities.Data>
    {
        public void Configure(EntityTypeBuilder<QuestionnaireCore.Data.Entities.Data> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
