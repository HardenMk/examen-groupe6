using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasseLib
{
    public interface IAdresse
    {
        int Id { get; set; }
        string quartier { get; set; }
        string commune { get; set; }
        string ville { get; set; }
        string pays { get; set; }
        string AdresseComplet { get; }
        int Nouveau();
        void Enregistrer(IAdresse adresse);
        void Supprimer(int id);
        List<IAdresse> Adresses();
        IAdresse OneAdresse(int id);
        List<IAdresse> RechercherAdresse(String txtrech);
    }
}
