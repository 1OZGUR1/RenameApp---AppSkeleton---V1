using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RenameApp.Contracts
{
    public partial class OrderStatics
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string Id { get; set; } = String.Empty;

        [Display(Name = "Order1")]
        public string? OrderId { get; set; }

        [Display(Name = "Order")]
        public string? OrderId1 { get; set; }

        public virtual Orders? Order1 { get; set; }

        public virtual Orders? Order { get; set; }

        [StringLength(50)]
        public string? OrderSuccessRating { get; set; }

        [StringLength(50)]
        public string? ServiceResiverComment { get; set; }

        [StringLength(50)]
        public string? ServiceProviderComment { get; set; }
    }
}
