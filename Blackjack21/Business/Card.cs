using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack21.Business
{
    public class Card
    {
        // Couleur de la carte
        public string Suit { get; }

        // Valeur de la carte
        public string Rank { get; }

        // Image associee à la carte
        public Bitmap Image { get; }

        // Constructor
        public Card(string suit, string rank, Bitmap image)
        {
            Suit = suit;
            Rank = rank;
            Image = image;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
