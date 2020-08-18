using System;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace p2pCryptos.Models
{
    public class User
    {
        public User()
        {

        }

        [Key]
        [Required]
        public long Userid { get; set; }

        //[ForeignKey("Standard")]
        //[Required]
        public string Roleid { get; set; }

        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }

        [Required]
        [StringLength(50)]
        public string Emailaddress
        { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password
        { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Dateofbirth { get; set; }

        [Required]
        [StringLength(1000)]
        public string City { get; set; }

        [Required]
        [StringLength(1000)]
        public string Address { get; set; }

        [Required]
        [StringLength(1000)]
        public string Postalcode { get; set; }

        [Required]
        [StringLength(1000)]
        public string Country { get; set; }
    }
}

