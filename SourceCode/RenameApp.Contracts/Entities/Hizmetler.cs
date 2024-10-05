using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RenameApp.Contracts
{
    public partial class Hizmetler
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string Id { get; set; } = String.Empty;

        [Display(Name = "Base")]
        public string BaseId { get; set; } = String.Empty;

        [Display(Name = "User")]
        public string? UserId { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }

        public virtual Hizmetler Base { get; set; } = null!;

        [StringLength(50)]
        public string? SubName { get; set; }

        public virtual ServiceProvider? User { get; set; }

        public virtual ICollection<Hizmetler> Bases { get; set; } = new HashSet<Hizmetler>();
    }
}
