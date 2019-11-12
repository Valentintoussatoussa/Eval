using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval2019.ORM
{
    public class Intervention
    {
        public Intervention()
        {
            
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Ouverture { get; set; }

        [Required]
        public DateTime Fermeture { get; set; }

        public virtual Intervenant Intervenant { get; set; }
        public virtual Materiel Materiel { get; set; }
        public virtual Vehicule Vehicule { get; set; }

    }
}
