using AlpSozluk.Api.Domains.Models;
using AlpSozluk.Infrastructure.Persistence.EntityConfigurations;
using AlpSozluk.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlpSozluk.Infrastructure.Persistence.EntityConfigurations.Entry
{
    public class EntryFavoriteEntityConfiguration : BaseEntityConfiguration<EntryFavorite>
    {
        public override void Configure(EntityTypeBuilder<EntryFavorite> builder)
        {
            base.Configure(builder);

            builder.ToTable("entryfavorite", AlpSozlukDbContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.Entry)
                   .WithMany(i => i.EntryFavorites)
                   .HasForeignKey(i => i.EntryId);

            builder.HasOne(i => i.CreatedUser)
                   .WithMany(i => i.EntryFavorites)
                   .HasForeignKey(i => i.CreatedById);
        }
    }
}
