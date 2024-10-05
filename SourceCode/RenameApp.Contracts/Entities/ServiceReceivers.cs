using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RenameApp.Contracts
{
    public partial class ServiceReceivers
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string Id { get; set; } = String.Empty;

        [Display(Name = "User")]
        public string UserId { get; set; } = String.Empty;

        public virtual User User { get; set; } = null!;

        public DateTime? LastServiceDate { get; set; }

        public virtual ICollection<Orders> ServiceResivers { get; set; } = new HashSet<Orders>();
    }
}
