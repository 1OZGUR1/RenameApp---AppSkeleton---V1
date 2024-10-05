using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RenameApp.Contracts
{
    public partial class OrderSuccessType
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string Id { get; set; } = String.Empty;

        [StringLength(50)]
        public string? OrderSuccessType1 { get; set; }

        public virtual ICollection<Orders> OrdersOrderSuccessTypes { get; set; } = new HashSet<Orders>();
    }
}
