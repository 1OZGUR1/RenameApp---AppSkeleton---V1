using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RenameApp.Contracts
{
    public partial class SocialAdres
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string Id { get; set; } = String.Empty;

        [StringLength(50)]
        public string? YoutubeAdress { get; set; }

        [StringLength(50)]
        public string? TwitterAdress { get; set; }

        [StringLength(50)]
        public string? WhatsapAdress { get; set; }

        [StringLength(50)]
        public string? FacebookAdress { get; set; }

        public virtual ICollection<Contact> SocialAdress { get; set; } = new HashSet<Contact>();
    }
}
