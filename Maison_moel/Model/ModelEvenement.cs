using Maison_moel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_moel.Model
{
    public class ModelEvenement
    {
        public static List<Evenement> GetEvenements()
        {
            return Model.MonModel.Evenements.Include(x => x.IdTypeEvenementNavigation).ToList();
        }

        public static Evenement GetEvenementById(int id)
        {
            return Model.MonModel.Evenements.Find(id);
        }

        public static void ajoutEvenement(int idTypeEv, string description, DateTime date, string? image = null)
        {
            try
            {
                Evenement evenement = new Evenement
                {
                    IdTypeEvenement = idTypeEv,
                    DescriptionEvenement = description,
                    ImageEvenement = image ?? null,
                    DateEvenement = date
                };
                Model.MonModel.Evenements.Add(evenement);
                Model.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void modifierEvenement(Evenement evenement)
        {
            try
            {
                Evenement evenement1 = Model.MonModel.Evenements.Find(evenement.IdEvenement);
                evenement1.DescriptionEvenement = evenement.DescriptionEvenement;
                evenement1.DateEvenement = evenement.DateEvenement;
                evenement1.IdTypeEvenement = evenement.IdTypeEvenement;
                if (evenement.ImageEvenement != null)
                    evenement1.ImageEvenement = evenement.ImageEvenement;
                Model.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void supprimerEvenement(Evenement evenement)
        {
            try
            {
                Model.MonModel.Evenements.Remove(evenement);
                Model.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<TypeEvenement> GetTypeEvenement()
        {
            return Model.MonModel.TypeEvenements.ToList();
        }
    }
}
