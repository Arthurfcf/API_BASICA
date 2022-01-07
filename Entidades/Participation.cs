using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Entidades
{
    public class Participation
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required][MaxLength(50)][MinLength(3)]
        public string FirstName { get; set; }

        [Required][MaxLength(50)][MinLength(3)]
        public string LastName { get; set; }

        [Required]
        public float Value { get; set; }

    }
}
