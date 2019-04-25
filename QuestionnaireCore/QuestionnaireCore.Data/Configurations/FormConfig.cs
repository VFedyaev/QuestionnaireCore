using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuestionnaireCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Data.Configurations
{
    public class FormConfig : IEntityTypeConfiguration<Form>
    {
        public void Configure(EntityTypeBuilder<Form> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.NumberForm);
        }
    }
}
