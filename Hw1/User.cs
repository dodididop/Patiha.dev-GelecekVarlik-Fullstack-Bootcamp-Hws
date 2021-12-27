using System;
using System.ComponentModel.DataAnnotations;

namespace FirstApi
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20),MinLength(2)]
        public string Name { get; set; }
        [Required]
        [StringLength(25)]
        public string SurName { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
