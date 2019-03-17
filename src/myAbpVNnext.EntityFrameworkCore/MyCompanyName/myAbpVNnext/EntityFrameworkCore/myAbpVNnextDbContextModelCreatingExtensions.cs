﻿using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace myAbpVNnext.EntityFrameworkCore
{
    public static class myAbpVNnextDbContextModelCreatingExtensions
    {
        public static void ConfiguremyAbpVNnext(
            this ModelBuilder builder,
            Action<myAbpVNnextModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new myAbpVNnextModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                //b.ToTable(options.TablePrefix + "Questions", options.Schema);
                
                //Properties
                //b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Configure relations
                //b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Configure indexes
                //b.HasIndex(q => q.CreationTime);
            });
            */
        }
    }
}