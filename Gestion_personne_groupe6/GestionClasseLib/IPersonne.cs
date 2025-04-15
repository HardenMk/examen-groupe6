using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasseLib
{
    public interface IPersonne
    {
        int Id { get; set; }
        string Nom { get; set; }
        string Postnom { get; set; }
        string Prenom { get; set; }
        sexe Sex { get; set; }
        string NomComplet { get; }
        List<ITelephone> TelephonePersonnes { get; }
        int Nouveau();
        void Enregistrer(IPersonne personne);
        void Supprimer(int id);
        List<IPersonne> Personnes();
        IPersonne OnePersonne(int id);
    }
}
