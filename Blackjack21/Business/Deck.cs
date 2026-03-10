using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack21.Business
{
    public class Deck
    {
        // Pile represente le deck (Picked du haut)
        private Stack<Card> cards = new Stack<Card>();

        // Random Number
        private Random rng = new Random();

        // Couleurs (suits)
        private readonly string[] suits = { "hearts", "diamonds", "clubs", "spades" };

        // Valeurs (rangs)
        private readonly string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };


        // Constructor Initialise le deck et mélange
        public Deck()
        {
            LoadDeck(); // Chargement de 52 cartes
            Shuffle(); // Mélange les cartes
        }


        // Chargement 52 cartes (Cartes -> Associer Image)
        private void LoadDeck()
        {
            // Vide la pile
            cards.Clear();

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    string rankNumber = rank == "ace" ? "01" :
                                        rank == "jack" ? "11" :
                                        rank == "queen" ? "12" :
                                        rank == "king" ? "13" : rank.PadLeft(2, '0');

                    string resourceName = $"{suit[0]}{rankNumber}";  // c01 ....

                    // Recupere Image correspondante dans les Ressources
                    Bitmap image = (Bitmap)Properties.Resources.ResourceManager.GetObject(resourceName);

                    if (image != null)
                    {
                        cards.Push(new Card(suit, rank, image));
                    }
                }
            }
        }


        // Mélange les cartes (Algorithme Fisher-Yates)
        public void Shuffle()
        {
            List<Card> shuffledList = cards.ToList();

            for (int i = shuffledList.Count - 1; i > 0; i--)
            {
                int swapIndex = rng.Next(i + 1);
                (shuffledList[i], shuffledList[swapIndex]) = (shuffledList[swapIndex], shuffledList[i]);
            }

            // Remet les cartes mélangées dans la pile
            cards = new Stack<Card>(shuffledList);
        }

        // Tire une carte du paquet (Pop)
        public Card DrawCard()
        {
            return cards.Count > 0 ? cards.Pop() : null;
        }
    }
}
