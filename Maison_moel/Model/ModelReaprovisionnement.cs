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

        public static List<Reapprovisionnement> ListeReapprovisionnementParPage(int nbElementParPage, int position)
        {
            var query = Model.MonModel.Reapprovisionnements
                .Include(x => x.IdPlatNavigation)
                .OrderBy(x => x.DateHeureReapro);
            return query
                .Skip((position - 1) * nbElementParPage)
                .Take(nbElementParPage)
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

        public static int NombreDemandeReaprovisionnement()
        {
            return Model.MonModel.Reapprovisionnements.Count();
        }

        public static bool NouveauReapprovisionnement(int idPlat, int quantite)
        {
            bool result = true;
            try
            {
                Reapprovisionnement reapprovisionnement = new Reapprovisionnement
                {
                    DateHeureReapro = DateTime.Now,
                    IdPlat = idPlat,
                    QuantiteReapro = quantite
                };

                Plat plat = Model.MonModel.Plats.Find(idPlat);
                plat.Quantite += quantite;

                Model.MonModel.Reapprovisionnements.Add(reapprovisionnement);
                Model.MonModel.SaveChanges();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
    }
}
