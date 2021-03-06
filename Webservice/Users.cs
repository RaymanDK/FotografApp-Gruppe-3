namespace Webservice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Tlf { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int TypeOfUserId { get; set; }

        public int Id { get; set; }
    }
}
