using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RepositoryPattern1.Model
{
    [Keyless]
    public partial class Registraction
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? UserName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Password { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? RetypePassword { get; set; }
        public int? EmpId { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Mobile { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Name { get; set; }
        public bool? IsActive { get; set; }
    }
}
