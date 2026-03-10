using Blackjack21.Business;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Blackjack21.Data
{
    public static class GestionJoueurs
    {
        // filepath pour fichier de sauvegarde
        private static readonly string filePath = "joueurs.json";

        public static List<Joueur> ChargerJoueurs()
        {
            // Si le fichier existe pas on retourne une liste vide
            if (!File.Exists(filePath))
                return new List<Joueur>();

            // Lecture contenu JSON
            string json = File.ReadAllText(filePath);

            // Deserialize du contenu en une liste de joueurs
            return JsonSerializer.Deserialize<List<Joueur>>(json);
        }

        public static void SauvegarderJoueurs(List<Joueur> joueurs)
        {
            // JsonSerializer de la liste en format JSON lisible (indente)
            string json = JsonSerializer.Serialize(joueurs, new JsonSerializerOptions { WriteIndented = true });

            // Write dans le fichier
            File.WriteAllText(filePath, json);
        }
    }
}
