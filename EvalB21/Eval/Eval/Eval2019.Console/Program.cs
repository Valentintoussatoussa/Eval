using Eval2019.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Eval2019.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContexteBDD())
            {
                //La sélection et affectation du véhicule de l'intervenant
                if (db.Vehicules.Any(v => v.Intervenant == null))
                {
                    var r1 = from v in db.Vehicules
                             where v.Intervenant == null
                             select v.First;
                    r1.Intervenant == Lintervenant;
                }
                else
                {
                    WriteLine("Il n'y a plus de véhicule disponible.");
                }
            }
        }
    }
}
