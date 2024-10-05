using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RenameApp.Contracts
{
    public partial class Blog
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string Id { get; set; } = String.Empty;

        [Display(Name = "User")]
        public string? UserId { get; set; }

        [Display(Name = "BaseComment1")]
        public string? BaseCommentId { get; set; }

        public virtual User? User { get; set; }

        [StringLength(50)]
        public string? BaseComment { get; set; }

        public virtual Blog? BaseComment1 { get; set; }

        [StringLength(50)]
        public string? SubComent { get; set; }

        public virtual ICollection<Blog> BaseComments { get; set; } = new HashSet<Blog>();
    }
}
