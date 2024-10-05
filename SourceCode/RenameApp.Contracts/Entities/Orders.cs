using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RenameApp.Contracts
{
    public partial class Orders
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string Id { get; set; } = String.Empty;

        [Display(Name = "ServiceProvider")]
        public string? ServiceProviderId { get; set; }

        [Display(Name = "ServiceResiver")]
        public string? ServiceResiverId { get; set; }

        [Display(Name = "Adress")]
        public string? AdressId { get; set; }

        [Display(Name = "OrdersOrderSuccessType")]
        public string? OrdersSuccsesType { get; set; }

        public virtual ServiceProvider? ServiceProvider { get; set; }

        public virtual ServiceReceivers? ServiceResiver { get; set; }

        public virtual Address? Adress { get; set; }

        public virtual OrderSuccessType? OrdersOrderSuccessType { get; set; }

        public virtual ICollection<OrderStatics> OrderStaticss { get; set; } = new HashSet<OrderStatics>();
    }
}
