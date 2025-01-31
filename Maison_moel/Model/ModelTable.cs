using Maison_moel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_moel.Model
{
    public class ModelTable
    {
        public static List<Table> ListeTable()
        {
            return Model.MonModel.Tables.ToList();
        }

        public static List<Commande> ListeCommandeParTable(int idtable)
        {
            return Model.MonModel.Commandes.Where(c => c.IdReservationNavigation.IdTable == idtable).ToList();
        }
    }
}