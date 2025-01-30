using Maison_moel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_moel.Model
{
    public class ModelPlat
    {
        public static List<Plat> ListePlat()
        {
            return Model.MonModel.Plats.ToList();
        }

        public static bool AjouterPlat(Plat plat)
        {
            try
            {
                Model.MonModel.Plats.Add(plat);
                Model.MonModel.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ModifierPlat(Plat plat)
        {
            try
            {
                Plat platAModifier = Model.MonModel.Plats.Find(plat.IdPlat);
                platAModifier.IdCategoriePlat = plat.IdCategoriePlat;
                platAModifier.IdTypePlat = plat.IdTypePlat;
                platAModifier.NomPlat = plat.NomPlat;
                platAModifier.Quantite = plat.Quantite;
                platAModifier.DescriptionPlat = plat.DescriptionPlat;
                platAModifier.PrixHt = plat.PrixHt;
                platAModifier.ImagePlat = plat.ImagePlat;
                Model.MonModel.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Plat recupPlat(int idPlat)
        {
            Plat plat;
            try
            {
                plat = Model.MonModel.Plats.Find(idPlat);
            }
            catch (Exception)
            {
                plat = new Plat();
            }
            return plat;
        }
    }
}
