using System;
using System.Collections.Generic;
using System.Text;
using AlpSozluk.Common.ViewModels;


namespace AlpSozluk.Api.Domains.Models
{
    public class EntryCommentVote : BaseEntity
    {

        public Guid EntryCommentId { get; set; }

        public VoteType VoteType { get; set; }

        public Guid CreatedById { get; set; }

        public virtual EntryComment EntryComment {get; set;}


    }
}
