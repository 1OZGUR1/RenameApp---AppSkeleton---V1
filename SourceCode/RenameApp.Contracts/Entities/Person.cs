using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RenameApp.Contracts
{
    public partial class Person
    {
        [Required]
        [StringLength(20)]
        [Key]
        public string Id { get; set; } = String.Empty;

        [Display(Name = "User")]
        public string? UserId { get; set; }

        [StringLength(50)]
        public string ServiceProviderId { get; set; } = String.Empty;

        [StringLength(10)]
        public string? SurName { get; set; }

        [StringLength(11)]
        public string? CitizenshipNumber { get; set; }

        public virtual User? User { get; set; }
    }
}
