using System;
using System.Collections.Generic;
using System.Text;

namespace AlpSozluk.Api.Domains.Models
{
    public class EntryCommentFavorite:BaseEntity

    {
       
        public Guid CreatedById { get; set; }

        public Guid EntryCommentId { get; set; }

        public virtual User CreatedUser { get; set; }

        public virtual EntryComment EntryComment{ get; set; }

       

    }
}
