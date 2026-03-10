using Blackjack21.Business;
using Blackjack21.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Blackjack21.UI
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();

            // Effets bouton Register
            BtnRegister.MouseEnter += BtnRegister_MouseEnter;
            BtnRegister.MouseLeave += BtnRegister_MouseLeave;

            // Effets bouton Login
            BtnLogin.MouseEnter += BtnLogin_MouseEnter;
            BtnLogin.MouseLeave += BtnLogin_MouseLeave;

        }

        // ENREGISTREMENT D'UN NOUVEL UTILISATEUR
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string nom = TxtUsername.Text.Trim();
            string motDePasse = TxtPassword.Text.Trim();
            int solde = 0; // Solde Initial


            // Validation
            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(motDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }


            // Vérifie nom existe déjà
            List<Joueur> joueurs = GestionJoueurs.ChargerJoueurs();

            foreach (var j in joueurs)
            {
                if (j.Nom == nom)
                {
                    MessageBox.Show("Ce nom d'utilisateur existe déjà !");
                    return;
                }
            }

            // Creation d’un nouveau joueur
            Joueur nouveauJoueur = new Joueur
            {
                Nom = nom,
                MotDePasse = motDePasse,
                Balance = solde
            };

            // Ajoute à la liste
            joueurs.Add(nouveauJoueur);

            // Sauvegarde dans le fichier JSON
            GestionJoueurs.SauvegarderJoueurs(joueurs);
            MessageBox.Show("Inscription réussie !");

            // Ouvrir la page de jeu
            FormPlay playForm = new FormPlay(nouveauJoueur);

            // Revenir ici si FormPlay est fermé
            playForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            playForm.Show();
        }

        // Survol button register
        private void BtnRegister_MouseEnter(object sender, EventArgs e)
        {
            BtnRegister.Image = Properties.Resources.button_registerhover;
        }


        // Survol button register
        private void BtnRegister_MouseLeave(object sender, EventArgs e)
        {
            BtnRegister.Image = Properties.Resources.button_register;
        }


        // CONNEXION D'UN UTILISATEUR EXISTANT
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string nom = TxtUsername.Text.Trim();
            string motDePasse = TxtPassword.Text.Trim();

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(motDePasse))
            {
                MessageBox.Show("Veuillez entrer votre nom et mot de passe");
                return;
            }

            List<Joueur> joueurs = GestionJoueurs.ChargerJoueurs();

            Joueur joueurConnecte = null;


            // Recherche du joueur avec les bons identifiants
            foreach (var j in joueurs)
            {
                if (j.Nom == nom && j.MotDePasse == motDePasse)
                {
                    joueurConnecte = j;
                    break;
                }
            }


            // Si trouvé -> lance le jeu
            if (joueurConnecte != null)
            {
                MessageBox.Show("Connexion réussie !");
                FormPlay playForm = new FormPlay(joueurConnecte);
                playForm.FormClosed += FormRegister_FormClosed;
                playForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nom ou mot de passe incorrect");
            }
        }


        // Survol button login
        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            BtnLogin.Image = Properties.Resources.button_loginhover;
        }


        // Survol button login
        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            BtnLogin.Image = Properties.Resources.button_login;
        }


        // Lorsque le formulaire de jeu -> this.Close()
        private void FormRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
