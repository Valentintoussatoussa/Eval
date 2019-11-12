using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval2019.ORM
{
    public class Vehicule
    {
        public Vehicule()
        {

        }

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Marque { get; set; }

        [StringLength(10)]
        [Required]
        public string Immatriculation { get; set; }

        [StringLength(50)]
        [Required]
        public string Modele { get; set; }

        [Required]
        public int volumeUtile { get; set; }

        public virtual Intervenant Intervenant { get; set; }
    }
}
