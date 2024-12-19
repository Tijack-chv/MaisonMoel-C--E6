using Maison_moel.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;



namespace Maison_moel.Model
{
    internal class ModConnexion
    {
        

        public static Personne RecupererPersonne(string login)
        {
            Personne personne = new();
            try
            {
                personne = Model.MonModel.Personnes.First(a => a.Email == login);
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'adresse mail saisie n'est pas reconnu !");
            }
            return personne;
        }

        public static List<Admin> RecupererAdmins()
        {
            
            List<Admin> personne = new();
            try
            {
                personne = Model.MonModel.Admins.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Probleme recup admin");
            }
            return personne;
        }

        public static List<Cuisinier> RecupererCuisiniers()
        {
            
            List<Cuisinier> personne = new();
            try
            {
                personne = Model.MonModel.Cuisiniers.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Probleme recup cuisinier");
            }
            return personne;
        }


        public static bool ConnexionAdmin(string mail, string mdp)
        {
            bool connexion = true;

            Personne personne = new();

            personne = RecupererPersonne(mail);

            if (personne.IdPersonne == 0)
            {
                connexion = false;
            }
            else if (!BC.Verify(mdp, personne.Password))
            {
                MessageBox.Show("Le mot de passe est incorrect !");
                connexion = false;
            }
            return connexion;
        }
    }
}
