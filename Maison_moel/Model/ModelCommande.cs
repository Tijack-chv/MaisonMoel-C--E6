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
    }
}
