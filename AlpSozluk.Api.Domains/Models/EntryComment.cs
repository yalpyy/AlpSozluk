﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AlpSozluk.Api.Domains.Models
{
    public class EntryComment:BaseEntity
    {
        public string Content { get; set; }

        public Guid CreatedById { get; set; }
   
    
        public Guid EntryId { get; set; }

        public virtual Entry Entry { get; set; }     
        
        public virtual User CreatedBy { get; set; }

        public virtual ICollection<EntryCommentVote> EntryCommentVotes { get; set; }

        public virtual ICollection<EntryCommentFavorite> EntryCommentFavorites { get; set; }


    }
}