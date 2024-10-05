using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RenameApp.Contracts
{
    public partial class Sehir
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string Id { get; set; } = String.Empty;

        [StringLength(50)]
        public string? Ad { get; set; }

        public virtual ICollection<Ilce> IlceSehirs { get; set; } = new HashSet<Ilce>();
    }
}
