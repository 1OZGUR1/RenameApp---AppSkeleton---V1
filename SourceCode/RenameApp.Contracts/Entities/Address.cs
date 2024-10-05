using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RenameApp.Contracts
{
    public partial class Address
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string Id { get; set; } = String.Empty;

        [Display(Name = "AddressIlce")]
        public string? IlceFk { get; set; }

        public virtual Ilce? AddressIlce { get; set; }

        [StringLength(250)]
        public string? AdressDetail { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; } = new HashSet<Contact>();

        public virtual ICollection<Orders> Orderss { get; set; } = new HashSet<Orders>();
    }
}
