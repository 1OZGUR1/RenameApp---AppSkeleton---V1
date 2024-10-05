using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RenameApp.Contracts
{
    public partial class User
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string Id { get; set; } = String.Empty;

        [Display(Name = "Contact")]
        public string? ContactId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; } = String.Empty;

        [StringLength(50)]
        public string? Password { get; set; }

        [StringLength(50)]
        public string? Salt { get; set; }

        [StringLength(10)]
        public string? Name { get; set; }

        public virtual Contact? Contact { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; } = new HashSet<Blog>();

        public virtual ICollection<Corporate> Corporates { get; set; } = new HashSet<Corporate>();

        public virtual ICollection<Person> Persons { get; set; } = new HashSet<Person>();

        public virtual ICollection<ServiceProvider> ServiceProviders { get; set; } = new HashSet<ServiceProvider>();

        public virtual ICollection<ServiceReceivers> ServiceReceiverss { get; set; } = new HashSet<ServiceReceivers>();
    }
}
