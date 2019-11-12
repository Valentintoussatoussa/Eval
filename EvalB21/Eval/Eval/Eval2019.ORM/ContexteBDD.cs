using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval2019.ORM
{
    public class ContexteBDD : DbContext
    {
        public ContexteBDD()
            : base("maChaineDeConnexion")
        {

        }

        public virtual DbSet<Materiel> Stocks { get; set; }
        public virtual DbSet<Vehicule> Vehicules{ get; set; }
        public virtual DbSet<Intervenant> Intervenants{ get; set; }
        public virtual DbSet<Intervention> Interventions { get; set; }
    }
}
