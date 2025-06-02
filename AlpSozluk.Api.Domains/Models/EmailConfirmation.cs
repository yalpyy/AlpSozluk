using System;
using System.Collections.Generic;
using System.Text;

namespace AlpSozluk.Api.Domains.Models
{
    public class EmailConfirmation:BaseEntity
    {
        public string OldEmailAddress {  get; set; }

        public string NewEmailAddress { get; set; }

    }
}
