using System;
using System.Collections.Generic;
using System.Text;

namespace AlpSozluk.Api.Domains.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }    

        public DateTime CreatedDate { get; set; }
    }
}
