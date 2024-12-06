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
        

        public static Admin RecupererAdmin(string login)
        {
            Admin admin = new();
            try
            {
                admin = Model.MonModel.Admins.First(a => a.Email == login);
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'adresse mail saisie n'est pas reconnu !");
            }
            return admin;
        }


        public static bool ConnexionAdmin(string mail, string mdp)
        {
            bool connexion = true;

            Admin admin = new();

            admin = RecupererAdmin(mail);

            if (admin.Idpersonne == 0)
            {
                connexion = false;
            }
            else if (!BC.Verify(mdp, admin.Password))
            {
                MessageBox.Show("Le mot de passe est incorrect !");
                connexion = false;
            }
            return connexion;
        }
    }
}
