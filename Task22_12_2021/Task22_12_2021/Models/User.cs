using System;
using System.ComponentModel.DataAnnotations;

namespace Task22_12_2021.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Surname { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(250)]
        public string Photo { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
