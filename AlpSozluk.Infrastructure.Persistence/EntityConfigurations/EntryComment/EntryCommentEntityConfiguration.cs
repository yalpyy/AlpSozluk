using AlpSozluk.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using AlpSozluk.Infrastructure.Persistence.EntityConfigurations;
namespace AlpSozluk.Infrastructure.Persistence.EntityConfigurations.EntryComment;

public class EntryCommentEntityConfiguration : BaseEntityConfiguration<Api.Domains.Models.EntryComment>
{
    public override void Configure(EntityTypeBuilder<Api.Domains.Models.EntryComment> builder)
    {
        base.Configure(builder);

        builder.ToTable("entrycomment", AlpSozlukDbContext.DEFAULT_SCHEMA);

        builder.HasOne(i => i.CreatedBy)
            .WithMany(i => i.EntryComments)
            .HasForeignKey(i => i.CreatedById);

        builder.HasOne(i => i.Entry)
            .WithMany(i => i.EntryComments)
            .HasForeignKey(i => i.EntryId);
    }
}
