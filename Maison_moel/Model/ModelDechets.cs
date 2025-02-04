using Maison_moel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_moel.Model
{
    public class ModelDechets
    {
        public static List<Dechet> GetDechets()
        {
            return Model.MonModel.Dechets.OrderByDescending(x => x.DateSaisie).ToList();
        }

        public static void AddDechet(Dechet dechet)
        {
            Model.MonModel.Dechets.Add(dechet);
            Model.MonModel.SaveChanges();
        }

        public static void UpdateDechet(int idDechet, float newPoids)
        {
            try
            {
                Dechet dechet = GetDechetById(idDechet);
                dechet.Poids = newPoids;
                Model.MonModel.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur lors de la modification du déchet : " + e.Message);
            }
        }

        public static void DeleteDechet(int idDechet)
        {
            try
            {
                Dechet dechet = GetDechetById(idDechet);
                Model.MonModel.Dechets.Remove(dechet);
                Model.MonModel.SaveChanges();
            } 
            catch (Exception e)
            {
                MessageBox.Show("Erreur lors de la suppression du déchet : " + e.Message);
            }
        }

        public static Dechet GetDechetById(int id)
        {
            return Model.MonModel.Dechets.FirstOrDefault(x => x.IdDechets == id);
        }

        public static bool getDechetbyDate(DateTime date)
        {
            return Model.MonModel.Dechets.Any(x => x.DateSaisie.Date == date.Date);
        }
    }
}
