using AlpSozluk.Infrastructure.Persistence.EntityConfigurations;
using AlpSozluk.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlpSozluk.Infrastructure.Persistence.EntityConfigurations.Entry
{
    public class EntryEntityConfiguration : BaseEntityConfiguration<Api.Domains.Models.Entry>
    {
        public override void Configure(EntityTypeBuilder<Api.Domains.Models.Entry> builder)
        {
            base.Configure(builder);

            builder.ToTable("entry", AlpSozlukDbContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.CreatedBy)
                   .WithMany(i => i.Entries)
                   .HasForeignKey(i => i.CreatedById);
        }
    }
}
