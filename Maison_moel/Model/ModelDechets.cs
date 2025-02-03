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
            return Model.MonModel.Dechets.ToList();
        }

        public static void AddDechet(Dechet dechet)
        {
            Model.MonModel.Dechets.Add(dechet);
            Model.MonModel.SaveChanges();
        }

        public static void UpdateDechet(Dechet dechet)
        {
            Model.MonModel.Dechets.Update(dechet);
            Model.MonModel.SaveChanges();
        }

        public static void DeleteDechet(Dechet dechet)
        {
            Model.MonModel.Dechets.Remove(dechet);
            Model.MonModel.SaveChanges();
        }
    }
}
