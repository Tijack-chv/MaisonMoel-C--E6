using Maison_moel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_moel.Model
{
    public class ModelPersonne
    {
        public static List<Personne> ListePersonne()
        {
            return Model.MonModel.Personnes.ToList();
        }

        public static List<Personne> ListeServeur()
        {
            return Model.MonModel.Personnes
            .Where(p => p.Serveur != null)
            .ToList();
        }

        public static List<Personne> ListeCuisinier()
        {
            return Model.MonModel.Personnes
            .Where(p => p.Cuisinier != null)
            .ToList();
        }

        public static List<Personne> ListeAdmin()
        {
            return Model.MonModel.Personnes
            .Where(p => p.Admin != null)
            .ToList();
        }

        public static List<Cuisinier> ListeCuisinierInfo()
        {
            return Model.MonModel.Cuisiniers
            .Include( c => c.IdPersonneNavigation)
            .Include(c => c.IdRoleNavigation)
            .ToList();
        }


        public static List<Admin> ListeAdminInfo() 
        { 
            return Model.MonModel.Admins
            .Include( c => c.IdPersonneNavigation)
            .ToList();
        
        }

        public static List<Serveur> ListeServeurInfo() 
        {
            return Model.MonModel.Serveurs
                .Include(c => c.IdPersonneNavigation)
                .Include(c => c.Commandes)
                .ToList();

        }

        public static List<Personne> ListePersonneNom(string recherche)
        {
            return Model.MonModel.Personnes
                .Where(c => c.Nom == recherche).ToList();
        }





    }
}
