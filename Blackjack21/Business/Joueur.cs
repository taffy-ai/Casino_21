using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack21.Business
{
    public class Joueur
    {
        // Nom player
        public string Nom { get; set; }

        // Mdp player
        public string MotDePasse { get; set; }

        // Solde actuel du joueur (argent pour miser)
        public int Balance { get; set; }
    }
}
