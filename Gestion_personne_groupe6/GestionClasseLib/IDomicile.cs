using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasseLib
{
    public interface IDomicile
    {
        int Id { get; set; }
        int id_personne { get; set; }
        int id_adresse { get; set; }
        string avenue { get; set; }
        int numero_avenue { get; set; }
        int Nouveau();
        void Enregistrer(IDomicile domicile);
        void Supprimer(int id);
        List<IDomicile> Domiciles();



    }
}
