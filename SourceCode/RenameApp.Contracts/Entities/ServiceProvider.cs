using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RenameApp.Contracts
{
    public partial class ServiceProvider
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string Id { get; set; } = String.Empty;

        [Display(Name = "User")]
        public string? UserId { get; set; }

        public virtual User? User { get; set; }

        [StringLength(50)]
        public string? ServicesId { get; set; }

        [StringLength(10)]
        public string? Rating { get; set; }

        public virtual ICollection<Hizmetler> Hizmetlers { get; set; } = new HashSet<Hizmetler>();

        public virtual ICollection<Orders> ServiceProviders { get; set; } = new HashSet<Orders>();
    }
}
