using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval2019.ORM
{
    public class Materiel
    {
        public Materiel()
        {
            
        }

        [Key]
        public int Ref { get; set; }

        [StringLength(50)]
        [Required]
        public string Nom { get; set; }

        [StringLength(255)]
        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime dateAchat { get; set; }

        public virtual Intervenant Intervenant { get; set; }

    }
}
