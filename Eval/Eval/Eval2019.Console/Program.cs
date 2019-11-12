using ChatonsCodeFirst.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatonsCodeFirst.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db=new ContexteBDD())
            {
                var categorie = db.Categories.First(c => c.Nom == "Mignons");

                var chaton = new Chaton()
                {
                    Nom="Mimi",
                    Couleur ="Roux",
                    Stérilisé =true,
                    Categorie =categorie
                };
                

                var proprio = new Proprietaire() {
                    Nom = "Ferronnière",
                    Prenom="Alan"
                };
                proprio.Chatons.Add(chaton);
                //ou
                chaton.Proprietaires.Add(proprio);

                db.Chatons.Add(chaton);
                db.SaveChanges();
            }
        }
    }
}
