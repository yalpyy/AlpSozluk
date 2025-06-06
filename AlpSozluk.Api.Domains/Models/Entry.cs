﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AlpSozluk.Api.Domains.Models
{
    public class Entry:BaseEntity
    {

        public string Subject { get; set; }
        public string Content { get; set; }

        public Guid CreatedById { get; set; }

        public virtual User CreatedBy {  get; set; }

        public virtual ICollection<EntryComment> EntryComments { get; set; }

        public virtual ICollection<EntryVote> EntryVotes { get; set; }

        public virtual ICollection<EntryFavorite> EntryFavorites{ get; set; }


    }
}
