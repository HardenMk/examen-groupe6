using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasseLib
{
    public interface IUtilisateur
    {
        int Id { get; set; }
        string Nom_user { get; set; }
        string Mot_de_passe { get; set; }       
        int Nouveau();
        void Enregistrer(IUtilisateur utilisateur);
        void Supprimer(int id);
        List<IUtilisateur> Utilisateurs();
        IUtilisateur OneUtilisateur(int id);
        List<IUtilisateur> RechercherUtilisateur(String txtrech);
        bool VerifierUtilisateur(string nom, string mtp);
    }
}
