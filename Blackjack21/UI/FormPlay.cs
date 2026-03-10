using Blackjack21.Business;
using Blackjack21.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Blackjack21.UI
{
    public partial class FormPlay : Form
    {
        private Deck deck; // Paquet de cartes pour la partie
        private Joueur joueur; // Intance du player

        private List<Card> playerHand = new List<Card>(); // Main du joueur (en cours)
        private List<Card> dealerHand = new List<Card>(); // Main du croupier
        
        
        private PictureBox dealerHiddenCard = null; // Carte hidden du croupier (face verso)

        private Joueur joueurActif; // Ref au joueur pour sa balance

        private int miseTotale = 0; // Mise totale pendant la partie
        private int dernierJeton = 0; // Dernier jeton selected

        private SoundPlayer ambiancePlayer; // Music Background




        public FormPlay(Joueur joueurConnecte)
        {
            InitializeComponent();
            joueur = joueurConnecte;
            joueurActif = joueur;

            // Music Background en boucle
            ambiancePlayer = new SoundPlayer(Properties.Resources.jazz_music);
            ambiancePlayer.PlayLooping();


        }

        // Gestion du clic (HIT) (tirer une carte)
        private void BtnHit_Click(object sender, EventArgs e)
        {
            Card drawnCard = deck.DrawCard();
            if (drawnCard != null)
            {
                playerHand.Add(drawnCard);
                PictureBox cardImage = CreateCardPicture(drawnCard.Image);
                flpPlayerCards.Controls.Add(cardImage);

                int playerScore = CalculateScore(playerHand);
                LblPlayerScore.Text = "Score: " + playerScore;

                if (playerScore > 21)
                {
                    MessageBox.Show("Bust! Vous avez dépassé 21", "Perdu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FinDePartie("dealer");
                }
            }
        }

        // Chargement Initial
        private void FormPlay_Load(object sender, EventArgs e)
        {
            if (joueurActif == null)
            {
                MessageBox.Show("Erreur de chargement du joueur.");
                this.Close();
                return;
            }
            deck = new Deck(); // Initialisation du paquet
            BtnHit.Enabled = false;
            BtnStand.Enabled = false;
            lblMise.Text = "Mise: 0 $";
            LblWelcome.Text = "Welcome: " + joueur.Nom;
            LblBalance.Text = "Balance: " + joueurActif.Balance + " $";

            // Affectation des valeurs (tag)
            PicChip1.Tag = 1;
            PicChip2.Tag = 5;
            PicChip3.Tag = 10;
            PicChip4.Tag = 25;
            PicChip5.Tag = 50;
            PicChip6.Tag = 100;

            // Ajout des événements pour chaque jeton
            AddChipEvents(PicChip1);
            AddChipEvents(PicChip2);
            AddChipEvents(PicChip3);
            AddChipEvents(PicChip4);
            AddChipEvents(PicChip5);
            AddChipEvents(PicChip6);

            PicFireworks.Image = Properties.Resources.firework;
            PicFireworks.Visible = false; // hidden au début
        }



        // Permet l'association des images jetons
        private Image GetChipImage(int montant, string etat)
        {
            switch (montant)
            {
                case 1:
                    return etat == "hover" ? Properties.Resources._1ChipHover : Properties.Resources._1Chip;
                case 5:
                    return etat == "hover" ? Properties.Resources._5ChipHover: Properties.Resources._5Chip;
                case 10:
                    return etat == "hover" ? Properties.Resources._10ChipHover : Properties.Resources._10Chip;
                case 25:
                    return etat == "hover" ? Properties.Resources._25ChipHover : Properties.Resources._25Chip;
                case 50:
                    return etat == "hover" ? Properties.Resources._50ChipHover : Properties.Resources._50Chip;
                case 100:
                    return etat == "hover" ? Properties.Resources._100ChipHover : Properties.Resources._100Chip;
                default:
                    return null;
            }
        }


        // Effect survol
        private void Chip_MouseEnter(object sender, EventArgs e)
        {
            PictureBox chip = sender as PictureBox;
            int montant = (int)chip.Tag;
            chip.Image = GetChipImage(montant, "hover");
        }

        // Restauration de l’image normale effect
        private void Chip_MouseLeave(object sender, EventArgs e)
        {
            PictureBox chip = sender as PictureBox;
            int montant = (int)chip.Tag;
            chip.Image = GetChipImage(montant, "normal");
        }


        // Clic sur un jeton pour miser
        private void Chip_Click(object sender, EventArgs e)
        {
            PictureBox chip = sender as PictureBox;
            int montant = (int)chip.Tag;

            if (joueurActif.Balance >= montant)
            {
                miseTotale += montant;
                joueurActif.Balance -= montant;
                dernierJeton = montant;

                lblMise.Text = $"Mise: {miseTotale} $";
                LblBalance.Text = $"Balance: {joueurActif.Balance} $";

                BtnDeal.Enabled = true; // Permettre de commencer la partie

            }
            else
            {
                MessageBox.Show("Solde insuffisant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Jetons event
        private void AddChipEvents(PictureBox chip)
        {
            chip.MouseEnter += Chip_MouseEnter;
            chip.MouseLeave += Chip_MouseLeave;
            chip.Click += Chip_Click;
        }



        // Permet l'association des images jetons (Disabled)
        private Image GetChipDisabledImage(int montant)
        {
            switch (montant)
            {
                case 1: return Properties.Resources._1ChipDisabled;
                case 5: return Properties.Resources._5ChipDisabled;
                case 10: return Properties.Resources._10ChipDisabled;
                case 25: return Properties.Resources._25ChipDisabled;
                case 50: return Properties.Resources._50ChipDisabled;
                case 100: return Properties.Resources._100ChipDisabled;
                default: return null;
            }
        }


        // Fin d'une manche
        private void FinDePartie(string gagnant)
        {
            int gain = 0;

            if (gagnant == "joueur")
            {
                gain = miseTotale; // Le joueur reçoit 2x sa mise
                joueurActif.Balance += miseTotale * 2;



                PicFireworks.Visible = true;
                PicFireworks.BringToFront();


                //Timer pour cacher
                var timer = new Timer();
                timer.Interval = 2000;
                timer.Tick += (s, ev) =>
                {
                    PicFireworks.Visible = false;
                    timer.Stop();
                };
                timer.Start();


                lblGain.Text = $"Gain: +{gain} $";
                lblGain.ForeColor = Color.LimeGreen;
            }
            else if (gagnant == "dealer")
            {
                lblGain.Text = $"Perte: -{miseTotale} $";
                lblGain.ForeColor = Color.Red;
            }
            else if (gagnant == "egalite")
            {
                joueurActif.Balance += miseTotale; // remboursement
                lblGain.Text = "Égalité: 0 $";
                lblGain.ForeColor = Color.Goldenrod;
            }

            // Réactiver les chips
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox chip && chip.Tag != null)
                {
                    int montant = (int)chip.Tag;
                    chip.Image = GetChipImage(montant, "normal");
                    chip.Enabled = true;
                }
            }

            // Vider les cartes
            flpPlayerCards.Controls.Clear();
            flpDealerCards.Controls.Clear();

            // Réinitialiser les scores et mise
            miseTotale = 0;
            dernierJeton = 0;
            lblMise.Text = "Mise: 0 $";
            LblBalance.Text = $"Balance: {joueurActif.Balance} $";
            LblPlayerScore.Text = "Score: ";
            LblDealerScore.Text = "Score: ";

            // Réactiver les boutons
            BtnHit.Enabled = false;
            BtnStand.Enabled = false;
            BtnDeal.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;

            // Reset deck et mains
            deck = new Deck();
            playerHand.Clear();
            dealerHand.Clear();

            // Sauvegarder le nouveau solde
            var joueurs = GestionJoueurs.ChargerJoueurs();
            foreach (var j in joueurs)
            {
                if (j.Nom == joueurActif.Nom)
                {
                    j.Balance = joueurActif.Balance;
                    break;
                }
            }


            if (joueurActif.Balance == 0)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.lose);
                player.Play();

                MessageBox.Show("Vous avez perdu tout votre argent !", "Échec", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GestionJoueurs.SauvegarderJoueurs(joueurs);
        }


        // Lancement d'une nouvelle partie
        private void BtnDeal_Click(object sender, EventArgs e)
        {

            if (miseTotale == 0)
            {
                MessageBox.Show("Vous devez miser avant de commencer !");
                return;
            }

            // Prep du deck et des mains
            deck = new Deck(); // Nv Deck a chaque Round
            playerHand.Clear();
            dealerHand.Clear();
            flpPlayerCards.Controls.Clear();
            flpDealerCards.Controls.Clear();



            // Désactiver les chips visuellement
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox chip && chip.Tag != null)
                {
                    int montant = (int)chip.Tag;
                    chip.Image = GetChipDisabledImage(montant);
                    chip.Enabled = false;
                }
            }

            // Deal 2 cartes au player
            for (int i = 0; i < 2; i++)
            {
                var card = deck.DrawCard();
                if (card != null)
                {
                    playerHand.Add(card);
                    PictureBox pic = CreateCardPicture(card.Image);
                    flpPlayerCards.Controls.Add(pic);
                }
            }

            // Deal 1 une carte au dealer
            var visibleCard = deck.DrawCard();
            dealerHand.Add(visibleCard);
            flpDealerCards.Controls.Add(CreateCardPicture(visibleCard.Image));

            // Deal 1 une carte hidden
            var hiddenCard = deck.DrawCard();
            dealerHand.Add(hiddenCard);
            dealerHiddenCard = CreateCardPicture(Properties.Resources.b1fv); // Card hidden
            flpDealerCards.Controls.Add(dealerHiddenCard);

            // update des scores
            LblPlayerScore.Text = "Score: " + CalculateScore(playerHand);
            LblDealerScore.Text = "Score: " + CalculateScore(new List<Card> { visibleCard });

            // Activation des boutons
            BtnHit.Enabled = true;
            BtnStand.Enabled = true;
            BtnDeal.Enabled = false;

            button1.Enabled = false;
            button2.Enabled = false;

        }

        // Calcul du score d'une main
        private int CalculateScore(List<Card> hand)
        {
            int score = 0;
            int aceCount = 0;

            foreach (var card in hand)
            {
                if (int.TryParse(card.Rank, out int value))
                {
                    score += value;
                }
                else if (card.Rank == "jack" || card.Rank == "queen" || card.Rank == "king")
                {
                    score += 10;
                }
                else if (card.Rank == "ace")
                {
                    aceCount++;
                    score += 11;
                }
            }
            while (score > 21 && aceCount > 0)
            {
                score -= 10;
                aceCount--;
            }

            return score;
        }

        // Fonction pour créer une carte visuelle
        private PictureBox CreateCardPicture(Image img)
        {
            PictureBox pic = new PictureBox();
            pic.Image = img;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Size = new Size(100, 140);
            return pic;
        }



        // Gestion du clic Stand (fin du tour du joueur)
        private void BtnStand_Click(object sender, EventArgs e)
        {

            BtnDeal.Enabled = false;

            // Affichage de la carte cachée du croupier
            flpDealerCards.Controls.Remove(dealerHiddenCard);
            PictureBox revealed = CreateCardPicture(dealerHand[1].Image);
            flpDealerCards.Controls.Add(revealed);

            // Le croupier tire jusqu’à 17
            int dealerScore = CalculateScore(dealerHand);
            while (dealerScore < 17)
            {
                Card card = deck.DrawCard();
                if (card != null)
                {
                    dealerHand.Add(card);
                    flpDealerCards.Controls.Add(CreateCardPicture(card.Image));
                    dealerScore = CalculateScore(dealerHand);
                }
            }

            // Calcul des scores
            int playerScore = CalculateScore(playerHand);
            LblDealerScore.Text = "Score: " + dealerScore;
            LblPlayerScore.Text = "Score: " + playerScore;

            // Determiner winner
            string gagnant;
            if (dealerScore > 21 || playerScore > dealerScore)
                gagnant = "joueur";
            else if (playerScore == dealerScore)
                gagnant = "egalite";
            else
                gagnant = "dealer";

            if (gagnant == "egalite")
            {
                joueurActif.Balance += miseTotale; // Remboursement
                MessageBox.Show("Égalité ! Mise retournée");
            }
            else if (gagnant == "joueur")
            {
                MessageBox.Show("Vous avez gagné !");
            }
            else
            {
                MessageBox.Show("Le croupier a gagné !");
            }

            FinDePartie(gagnant);
        }


        // Recharger la balance (form)
        private void BtnTopUp_Click(object sender, EventArgs e)
        {
            FormTopUp topUpForm = new FormTopUp(joueur);
            topUpForm.ShowDialog();

            LblBalance.Text = "Balance: " + joueur.Balance + "$";
        }


        // Augmenter la mise avec le dernier jeton
        private void button1_Click(object sender, EventArgs e)
        {
            if (dernierJeton == 0)
            {
                MessageBox.Show("Sélectionnez un jeton d'abord");
                return;
            }

            if (joueurActif.Balance >= dernierJeton)
            {
                miseTotale += dernierJeton;
                joueurActif.Balance -= dernierJeton;

                lblMise.Text = $"Mise: {miseTotale} $";
                LblBalance.Text = $"Balance: {joueurActif.Balance} $";
            }
            else
            {
                MessageBox.Show("Solde insuffisant");
            }
        }


        // Diminuer la mise avec le dernier jeton
        private void button2_Click(object sender, EventArgs e)
        {
            if (dernierJeton == 0)
            {
                MessageBox.Show("Sélectionnez un jeton d'abord");
                return;
            }

            if (miseTotale >= dernierJeton)
            {
                miseTotale -= dernierJeton;
                joueurActif.Balance += dernierJeton;

                lblMise.Text = $"Mise: {miseTotale} $";
                LblBalance.Text = $"Balance: {joueurActif.Balance} $";
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas retirer plus que la mise actuelle");
            }
        }
    }
}
