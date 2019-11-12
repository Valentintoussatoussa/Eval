using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval2019.ORM
{
    public class Intervenant
    {
        public Intervenant()
        {
            //Chatons = new List<Chaton>();
        }
        [Key]
        public int Matricule { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(50)]
        public string Prenom { get; set; }

        //public virtual ICollection<Chaton> Chatons { get; set; }
    }
}
