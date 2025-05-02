using GestionDeLaConnexion;
using GestionClasseLib;
using System;
using System.Data;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                connexion connection = new connexion();

                connection.Serveur = @"DESKTOP-8JV1G3E\SQLEXPRESS";
                connection.Database = "gestion_personne";
                connection.User = "sa";
                connection.Password = "mk101214";
                ImplementerConnexion.getinstance().connections(connection);

                Console.WriteLine("Connection Successfuly !!!");
                Console.WriteLine("==========================");

                //Test ajout personnes

                //IPersonne pers2 = new Personne();
                //pers2.Id = 2;
                //pers2.Nom = "Israel";
                //pers2.Postnom = "Maz";
                //pers2.Prenom = "Damien";
                //pers2.Sex = sexe.Masculin;
                //pers2.Enregistrer(pers2);
                //Console.WriteLine("Personne2 ebregistrer !!!");
                //Console.WriteLine("==========================");

                //IPersonne pers4 = new Personne();
                //pers4.Id = 4;
                //pers4.Nom = "Mk";
                //pers4.Postnom = "Kah";
                //pers4.Prenom = "Digra";
                //pers4.Sex = sexe.Masculin;
                //pers4.Enregistrer(pers4);
                //Console.WriteLine("Personne4 ebregistrer !!!");
                //Console.WriteLine("==========================");

                //test suppression personnes //

                //pers2.Supprimer(pers2.Id);
                //Console.WriteLine("personne4 supprimer !!!");
                //Console.WriteLine("==========================");

                //test afficher donnees
                IPersonne pers = new Personne();
                pers = pers.OnePersonne(4);
                Console.WriteLine("\nListe une personne\n");
                Console.WriteLine("Id: " + pers.Id + " Nom: " + pers.Nom + " Postnom: " + pers.Postnom + " Prenom: " + pers.Prenom + " Genre: " + pers.Sex);
                Console.WriteLine("=======================================================================================================");

                //liste toutes les personnes
                Console.WriteLine("\nListe toutes les personnes\n");
                foreach (IPersonne p in pers.Personnes())
                {
                    Console.WriteLine("Id: " + p.Id + " Nom: " + p.Nom + " Postnom: " + p.Postnom + " Prenom: " + p.Prenom + " Genre: " + p.Sex);
                    Console.WriteLine("=======================================================================================================");
                }
                //test ajout numero telephone//

                //ITelephone tel1 = new Telephone();
                //tel1.Id = 1;
                //tel1.Id_proprietaire = 1;
                //tel1.Initial = "243";
                //tel1.Numero = "976208769";
                //tel1.Enregistrer(tel1);

                //Console.WriteLine("telephone 1 ebregistrer !!!");
                //Console.WriteLine("==========================");

                //ITelephone tel2 = new Telephone();
                //tel2.Id = 2;
                //tel2.Id_proprietaire = 1;
                //tel2.Initial = "242";
                //tel2.Numero = "905186784";
                //tel2.Enregistrer(tel2);

                //Console.WriteLine("telephone 2 ebregistrer !!!");
                //Console.WriteLine("==========================");

                //test suppression telephones //             

                //tel2.Supprimer(tel2.Id);
                //Console.WriteLine("telephone2 supprimer !!!");
                //Console.WriteLine("==========================");

                //test afficher donnees
                ITelephone tel = new Telephone();
                IPersonne persphone = new Personne();
                tel = tel.OneTelephone(1);
                persphone = persphone.OnePersonne(tel.Id_proprietaire);
                var nomproprio = persphone.ToString();
                Console.WriteLine("\nListe par numero\n");
                Console.WriteLine("Id: " + tel.Id + " Proprietaire: " + nomproprio + " Tel: " + tel.NumeroComplet);
                Console.WriteLine("=======================================================================================================");

                //liste tous les numeros
                Console.WriteLine("\nListe tous les numeros\n");
                foreach (ITelephone t in tel.Telephones())
                {
                    persphone = persphone.OnePersonne(t.Id_proprietaire);
                    nomproprio = persphone.ToString();
                    Console.WriteLine("Id: " + t.Id + " Proprietaire: " + nomproprio + " Tel: " + t.NumeroComplet);
                    Console.WriteLine("=======================================================================================================");
                }
                //liste tous les numeros par proprietaire
                Console.WriteLine("\nListe tous les numeros par proprietaire\n");
                List<ITelephone> listnumeros = tel.TelephonesPersonnes(1);

                persphone = pers.OnePersonne(1);
                nomproprio = persphone.ToString();
                Console.WriteLine(" Proprietaire: " + nomproprio);
                Console.WriteLine("============================");
                foreach (ITelephone t in tel.TelephonesPersonnes(1))
                {

                    Console.WriteLine("Id: " + t.Id + " Tel: " + t.NumeroComplet);
                    Console.WriteLine("===================================");
                }

                //test ajout adresse

                //IAdresse adr2 = new Adresse();
                //adr2.Id = 2;
                //adr2.quartier = "Himbi";
                //adr2.commune = "Goma";
                //adr2.ville = "Goma";
                //adr2.pays = "Rdc";
                //adr2.Enregistrer(adr2);
                //Console.WriteLine("Adresse2 enregistrer !!!");
                //Console.WriteLine("==========================");

                //IAdresse adr3 = new Adresse();
                //adr3.Id = 3;
                //adr3.quartier = "Katoyi";
                //adr3.commune = "Karisimbi";
                //adr3.ville = "Goma";
                //adr3.pays = "Rdc";
                //adr3.Enregistrer(adr3);

                //Console.WriteLine("Adresse3 enregistrer !!!");
                //Console.WriteLine("==========================");

                //test suppression adresses //             

                //adr2.Supprimer(adr2.Id);
                //Console.WriteLine("Adresse3 supprimer !!!");
                //Console.WriteLine("==========================");

                //test afficher donnees
                IAdresse adr = new Adresse();
                adr = adr.OneAdresse(2);
                Console.WriteLine("\nListe une adresse\n");
                Console.WriteLine("Id: " + adr.Id + " Quartier: " + adr.quartier + " Commune: " + adr.commune + " ville: " + adr.ville + " pays: " + adr.pays);
                Console.WriteLine("=================================================================================");

                //liste toutes les personnes
                Console.WriteLine("\nListe toutes les adresses\n");
                foreach (IAdresse a in adr.Adresses())
                {
                    Console.WriteLine("Id: " + a.Id + " Quartier: " + a.quartier + " Commune: " + a.commune + " ville: " + a.ville + " pays: " + a.pays);
                    Console.WriteLine("====================================================================================");
                }

                //test ajout domicile

                //IDomicile dom1 = new domicile();
                //dom1.Id = 1;
                //dom1.id_personne = 2;
                //dom1.id_adresse = 1;
                //dom1.avenue = "tulipiers";
                //dom1.numero_avenue = 234;
                //dom1.Enregistrer(dom1);

                //Console.WriteLine("domicile1 enregistrer !!!");
                //Console.WriteLine("==========================");

                //IDomicile dom2 = new domicile();
                //dom2.Id = 2;
                //dom2.id_personne = 1;
                //dom2.id_adresse = 2;
                //dom2.avenue = "de la paix";
                //dom2.numero_avenue = 10;
                //dom2.Enregistrer(dom2);

                //Console.WriteLine("domicile2 enregistrer !!!");
                //Console.WriteLine("==========================");

                //test suppression domiciles //             

                //dom1.Supprimer(dom1.Id);
                //Console.WriteLine("domicile1 supprimer !!!");
                //Console.WriteLine("==========================");

                //liste tous les domiciles
                Console.WriteLine("\nListe tous les domiciles\n");
                IDomicile dom = new domicile();

                foreach (IDomicile d in dom.Domiciles())
                {
                    persphone = persphone.OnePersonne(d.id_personne);
                    nomproprio = persphone.ToString();
                    adr = adr.OneAdresse(d.id_adresse);
                    Console.WriteLine("Id: " + d.Id + " Proprietaire: " + nomproprio + " Adresse: p." + adr.pays + ",v." + adr.ville + " C." + adr.commune + " Q." + adr.quartier + " Av." + d.avenue + " N°" + d.numero_domicile);
                    Console.WriteLine("=============================================================================================");
                }

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Connection error1, " + ex.Message);
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Connection error2, " + ex.Message);
            }
            finally
            {
               // ImplementerConnexion.fermerconnection();

            }

            Console.ReadLine();
        }
    }
}
