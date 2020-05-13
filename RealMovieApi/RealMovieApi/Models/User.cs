using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RealMovieApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]        
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }

    }
}
