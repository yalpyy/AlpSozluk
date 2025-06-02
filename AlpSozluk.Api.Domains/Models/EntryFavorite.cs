using System;
using System.Collections.Generic;
using System.Text;
using AlpSozluk.Common.ViewModels;

namespace AlpSozluk.Api.Domains.Models
{
    public class EntryFavorite:BaseEntity
    {


        public Guid EntryId { get; set; }

        public Guid CreatedById { get; set; }

        public virtual Entry Entry { get; set; }

        public virtual User CreatedUser { get; set; }



    }
}
