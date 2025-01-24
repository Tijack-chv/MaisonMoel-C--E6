using Maison_moel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_moel.Model
{
    public class ModelReaprovisionnement
    {
        public static List<Reapprovisionnement> ListeReaprovisionnement()
        {
            return Model.MonModel.Reapprovisionnements
                .Include(x => x.IdPlatNavigation)
                .ToList();
        }

        public static int NombreReaprovisionnement(int value)
        {
            return Model.MonModel.Plats.Where(x => x.Quantite < value).Count();
        }

        public static List<Plat> ListePlatAReapro(int value)
        {
            return Model.MonModel.Plats.Where(x => x.Quantite < value).ToList();
        }
    }
}
