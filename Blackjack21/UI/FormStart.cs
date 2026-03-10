using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack21.UI
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();

            // Image de base du bouton "Play"
            BtnPlay.Image = Properties.Resources.button_play;

            // Event (hover)
            BtnPlay.MouseEnter += BtnPlay_MouseEnter;
            BtnPlay.MouseLeave += BtnPlay_MouseLeave;
        }


        // Hover Effect sur l'entrer
        private void BtnPlay_MouseEnter(object sender, EventArgs e)
        {
            BtnPlay.Image = Properties.Resources.button_playhover;
        }

        // Hover effect sur survol
        private void BtnPlay_MouseLeave(object sender, EventArgs e)
        {
            BtnPlay.Image = Properties.Resources.button_play;
        
        }


        private void BtnPlay_Click_1(object sender, EventArgs e)
        {

        }

        // Formulaire ---> Register
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();


            register.FormClosed += FormStart_FormClosed;
            register.Show();
            this.Hide();
        }

        // Event ferme
        private void FormStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
