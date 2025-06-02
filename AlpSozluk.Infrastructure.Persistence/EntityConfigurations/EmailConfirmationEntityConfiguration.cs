﻿using AlpSozluk.Api.Domains.Models;
using AlpSozluk.Infrastructure.Persistence.EntityConfigurations;
using AlpSozluk.Api.Domains.Models;
using AlpSozluk.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlpSozluk.Api.Infrastructure.Persistence.EntityConfigurations;

public class EmailConfirmationEntityConfiguration : BaseEntityConfiguration<EmailConfirmation>
{
    public override void Configure(EntityTypeBuilder<EmailConfirmation> builder)
    {
        base.Configure(builder);

        builder.ToTable("emailconfirmation", AlpSozlukDbContext.DEFAULT_SCHEMA);
    }
}
