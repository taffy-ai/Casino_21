using Blackjack21.Business;
using Blackjack21.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack21.UI
{
    public partial class FormTopUp : Form
    {

        // Ref au joueur connected
        private Joueur joueur;

        public FormTopUp(Joueur joueurActif)
        {
            InitializeComponent();
            joueur = joueurActif;
        }

        // Événement click pour top up
        private void btnTopUp_Click(object sender, EventArgs e)
        {

            // Recup des données saisies
            string carteNum = TxtCardNumber.Text.Trim();
            string exp = TxtExp.Text.Trim();
            string cvv = TxtCVV.Text.Trim();
            string selectedAmount = CmbAmount.Text;

            // --- VALIDATION ---
            if (string.IsNullOrEmpty(carteNum) || carteNum.Length < 12)
            {
                MessageBox.Show("Entrer un numéro de carte valide");
                return;
            }

            // Verif que la carte est Visa (4) ou MasterCard (5)
            if (!carteNum.StartsWith("4") && !carteNum.StartsWith("5"))
            {
                MessageBox.Show("Seules les cartes Visa (4) et MasterCard (5) sont acceptées");
                return;
            }

            // Verif le format de la date d'expiration (doit contenir "/")
            if (string.IsNullOrEmpty(exp) || !exp.Contains("/"))
            {
                MessageBox.Show("Date d'expiration invalide, Format : MM/YY");
                return;
            }

            // Verif que le CVV est bien un nombre de 3 chiffres
            if (string.IsNullOrEmpty(cvv) || cvv.Length != 3 || !int.TryParse(cvv, out _))
            {
                MessageBox.Show("CVV invalide");
                return;
            }


            // Verif que l'utilisateur a sélectionné un montant valide
            if (string.IsNullOrEmpty(selectedAmount) || !int.TryParse(selectedAmount, out int amount))
            {
                MessageBox.Show("Veuillez sélectionner un montant à ajouter");
                return;
            }

            // Ajout du solde
            joueur.Balance += amount;


            // Save dans le fichier JSON avec nv Solde
            List<Joueur> joueurs = GestionJoueurs.ChargerJoueurs();
            foreach (var j in joueurs)
            {
                if (j.Nom == joueur.Nom)
                {
                    j.Balance = joueur.Balance;
                    break;
                }
            }

            // Sauvegarde de la liste modifiée
            GestionJoueurs.SauvegarderJoueurs(joueurs);


            // --- CONFIRMATION ---
            MessageBox.Show("Montant ajouté avec succès !");
            this.Close();
        }


        // Update du logo de carte (Visa/MasterCard) selon le numéro saisi
        private void TxtCardNumber_TextChanged(object sender, EventArgs e)
        {
            string cardNum = TxtCardNumber.Text.Trim();

            if (cardNum.StartsWith("4"))
            {
                PicLogoCard.Image = Properties.Resources.visa;
            }
            else if (cardNum.StartsWith("5"))
            {
                PicLogoCard.Image = Properties.Resources.mastercard;
            }
            else
            {
                PicLogoCard.Image = null;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
