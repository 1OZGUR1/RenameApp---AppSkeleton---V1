using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RenameApp.Contracts
{
    public partial class Ilce
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string Id { get; set; } = String.Empty;

        [Display(Name = "IlceSehir")]
        public string? SehirFk { get; set; }

        [StringLength(50)]
        public string? Ad { get; set; }

        public virtual Sehir? IlceSehir { get; set; }

        public virtual ICollection<Address> AddressIlces { get; set; } = new HashSet<Address>();
    }
}
