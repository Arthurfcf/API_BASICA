using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Entidades
{
    public class Participation
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codigo { get; set; }

        [Required][MaxLength(50)][MinLength(3)]
        public string FirstName { get; set; }

        [Required][MaxLength(50)][MinLength(3)]
        public string LastName { get; set; }

        [Required]
        public float Value { get; set; }

        public static implicit operator Participation(int v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator int(Participation v)
        {
            throw new NotImplementedException();
        }
    }
}
