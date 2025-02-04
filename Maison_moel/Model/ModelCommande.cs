using Maison_moel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_moel.Model
{
    public class ModelCommande
    {
        public static List<Commande> ListeCommande()
        {
            return Model.MonModel.Commandes.Include(c => c.IdEtatNavigation) 
            .Include(c => c.IdReservationNavigation).ThenInclude(a => a.IdTableNavigation)
            .Include(c => c.IdPersonneNavigation).ThenInclude(p => p.IdPersonneNavigation)
            .ToList();
        }

        public static List<Comporter> ListeComporter()
        {
            return Model.MonModel.Comporters.Include(x => x.IdPlatNavigation)
                .Include(x => x.IdEtatNavigation)
                .Include(x => x.IdCommandeNavigation)
                .OrderBy(x => x.IdCommande)
                .Where(x => x.IdCommandeNavigation.IdEtatNavigation.LibelleEtat != "Terminé")
                .Where(x => x.IdCommandeNavigation.IdEtatNavigation.LibelleEtat != "Annulée")
                .ToList();
        }

        public static List<Commande> ListeCommandeNonFini()
        {
            return Model.MonModel.Commandes.Where(x=> x.IdEtatNavigation.LibelleEtat == "Terminé").ToList();
        }
        
        public static List<Comporter> ListeCompleteComporterCommandeNonFini()
        {
            return Model.MonModel.Comporters.Include(x => x.IdPlatNavigation)
                .Include(x => x.IdCommandeNavigation)
                .Include(x => x.IdCommandeNavigation.IdEtatNavigation)
                .Where(x => x.IdCommandeNavigation.IdEtatNavigation.LibelleEtat == "Terminé")
                .ToList();
        }
        
        public static void updateEtatComporter(int idCommande, int idPlat, int idEtat)
        {
            try
            {
                Comporter comporter = Model.MonModel.Comporters.Find(idCommande,idPlat);
                comporter.IdEtat = idEtat;
                Model.MonModel.SaveChanges();
            } 
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void updateEtatCommande(int idCommande, int idEtat)
        {
            try
            {
                Commande commande = Model.MonModel.Commandes.Find(idCommande);
                commande.IdEtat = idEtat;
                Model.MonModel.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static int returnIdEtat(string libelle)
        {
            return Model.MonModel.Etats.Where(x => x.LibelleEtat == libelle).Select(x => x.IdEtat).FirstOrDefault();
        }

        public static List<Comporter> checkCommande(int idCommande)
        {
            return Model.MonModel.Comporters.Include(x => x.IdCommandeNavigation).Where(x => x.IdCommande == idCommande).ToList();
        }
    }
}