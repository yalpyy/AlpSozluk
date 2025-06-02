using System;
using System.Collections.Generic;
using System.Text;
using AlpSozluk.Common.ViewModels;


namespace AlpSozluk.Api.Domains.Models
{
    public class EntryVote : BaseEntity
    {

        public Guid EntryId { get; set; }

        public VoteType VoteType { get; set; }

        public Guid CreatedById { get; set; }

        public virtual Entry Entry {get; set;}


    }
}
