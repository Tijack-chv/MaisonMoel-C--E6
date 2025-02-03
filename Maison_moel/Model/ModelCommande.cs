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
                .Include(x => x.IdCommandeNavigation).ToList();
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
        
    }
}