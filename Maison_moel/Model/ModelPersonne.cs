using Maison_moel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace Maison_moel.Model
{
    public class ModelPersonne
    {
        public static List<Personne> ListePersonne()
        {
            List<Personne> personnes = new List<Personne>();

            personnes.AddRange(ListeServeur());
            personnes.AddRange(ListeCuisinier());
            personnes.AddRange(ListeAdmin());

            return personnes.OrderBy(p => p.IdPersonne).ToList();
        }

        public static List<Personne> ListePersonneArchiver()
        {
            List<Personne> personnes = new List<Personne>();

            personnes.AddRange(ListeServeurArchiver());
            personnes.AddRange(ListeCuisinierArchiver());
            personnes.AddRange(ListeAdminArchiver());

            return personnes.OrderBy(p => p.IdPersonne).ToList();
        }

        public static List<Personne> ListeServeur()
        {
            return Model.MonModel.Personnes
            .Where(p => p.Serveur != null)
            .Where(p => p.Archiver == 0)
            .ToList();
        }

        public static List<Personne> ListeCuisinier()
        {
            return Model.MonModel.Personnes
            .Where(p => p.Cuisinier != null)
            .Where(p => p.Archiver == 0)
            .ToList();
        }

        public static List<Personne> ListeAdmin()
        {
            return Model.MonModel.Personnes
            .Where(p => p.Admin != null)
            .Where(p => p.Archiver == 0)
            .ToList();
        }

        public static List<Personne> ListeServeurArchiver()
        {
            return Model.MonModel.Personnes
            .Where(p => p.Serveur != null)
            .Where(p => p.Archiver == 1)
            .ToList();
        }

        public static List<Personne> ListeCuisinierArchiver()
        {
            return Model.MonModel.Personnes
            .Where(p => p.Cuisinier != null)
            .Where(p => p.Archiver == 1)
            .ToList();
        }

        public static List<Personne> ListeAdminArchiver()
        {
            return Model.MonModel.Personnes
            .Where(p => p.Admin != null)
            .Where(p => p.Archiver == 1)
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

        public static List<Personne> ListePersonneNom(string recherche, bool archive)
        {
            if (archive)
            {
                return Model.MonModel.Personnes
                .Where(c => c.Nom == recherche).Where(c => c.Archiver == 1).ToList();
            }
            else
            {
                return Model.MonModel.Personnes
                    .Where(c => c.Nom == recherche).Where(c => c.Archiver == 0).ToList();
            }
        }

        public static Cuisinier GetCuisinierById(int id)
        {
            Cuisinier cuisiner = new Cuisinier();
            try
            {
                cuisiner = Model.MonModel.Cuisiniers.Include(c => c.IdPersonneNavigation).Include(c => c.IdRoleNavigation).First(x => x.IdPersonne == id);
            } catch
            {
                cuisiner = null;
            }
            
            return cuisiner;
        }

        public static Admin GetAdminById(int id)
        {
            Admin admin = new Admin();
            try
            {
                admin = Model.MonModel.Admins.Include(c => c.IdPersonneNavigation).First(x => x.IdPersonne == id);
            } catch
            {
                admin = null;
            }
            
            return admin;
        }

        public static Serveur GetServeurById(int id)
        {
            Serveur serveur = new Serveur();
            try
            {
                serveur = Model.MonModel.Serveurs.Include(c => c.IdPersonneNavigation).First(x => x.IdPersonne == id);
            } catch
            {
                serveur = null;
            }
            
            return serveur;
        }

        public static Personne GetPersonneById(int id)
        {
            Personne personne = new Personne();
            try
            {
                personne = Model.MonModel.Personnes.Include(c => c.Cuisinier).Include(c => c.Admin).Include(c => c.Serveur).First(x => x.IdPersonne == id);
            }
            catch
            {
                personne = null;
            }

            return personne;
        }

        public static void ArchiverPersonne(int id)
        {
            Personne personne = GetPersonneById(id);
            personne.Archiver = 1;
            Model.MonModel.SaveChanges();
        }

        public static void DesarchiverPersonne(int id)
        {
            Personne personne = GetPersonneById(id);
            personne.Archiver = 0;
            Model.MonModel.SaveChanges();
        }

        public static void ModifierMDP(int id, string mdp)
        {
            Personne personne = GetPersonneById(id);
            string hashMdp = BC.HashPassword(mdp);
            personne.Password = hashMdp;
            Model.MonModel.SaveChanges();
        }




    }
}
