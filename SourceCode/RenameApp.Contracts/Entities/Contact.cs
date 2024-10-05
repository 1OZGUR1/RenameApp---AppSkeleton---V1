using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RenameApp.Contracts
{
    public partial class Contact
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string Id { get; set; } = String.Empty;

        [Display(Name = "Adress")]
        public string? AdressId { get; set; }

        [Display(Name = "SocialAdres")]
        public string? SocialAdresId { get; set; }

        public virtual Address? Adress { get; set; }

        [StringLength(10)]
        public string? Gsm { get; set; }

        public virtual SocialAdres? SocialAdres { get; set; }

        [StringLength(50)]
        public string? Email { get; set; }

        public virtual ICollection<User> Contacts { get; set; } = new HashSet<User>();
    }
}
