using AlpSozluk.Api.Domains.Models;
using AlpSozluk.Infrastructure.Persistence.EntityConfigurations;
using AlpSozluk.Api.Domains.Models;
using AlpSozluk.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlpSozluk.Api.Infrastructure.Persistence.EntityConfigurations;

public class UserEntityConfiguration : BaseEntityConfiguration<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);

        builder.ToTable("user", AlpSozlukDbContext.DEFAULT_SCHEMA);
    }
}
