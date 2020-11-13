using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banque
{
    public static class Hollerith
    {
        /// <summary>
        /// Table de correspondance 
        /// </summary>
        private static Dictionary<char, int> _hollerith =
        new Dictionary<char, int>() { { 'A', 1 }, { 'B', 2 }, { 'C', 3 }, { 'D', 4 }, { 'E', 5 }, { 'F', 6 }, { 'G', 7 }, { 'H', 8 }, { 'I', 9 },
        { 'J', 1 }, { 'K', 2 }, { 'L', 3 }, { 'M', 4 }, { 'N', 5 }, { 'O', 6 }, { 'P', 7 }, { 'Q', 8 }, { 'R', 9 },
        { 'S', 2 }, { 'T', 3 }, { 'U', 4 }, { 'V', 5 }, { 'W', 6 }, { 'X', 7 }, { 'Y', 8 }, { 'Z', 9 }};
       
        /// <summary>
        /// Produit l'équivalent numérique d'un caractère alpha
        /// selon la table Hollerith si ce caractère est valide 
        /// La méthode renvoie alors True et l'équivalent numérique d'un caractère
        /// Sinon False et 0
        /// </summary>
        /// <param name="alpha">Caractère à convertir</param>
        /// <param name="equivalent">Equivalence numérique / hollerith</param>
        /// <returns>Vrai si transcodable, Faux sinon</returns>
        public static bool Transcoder(char alpha, out int equivalent)
        {

            if (_hollerith.ContainsKey(alpha))
            {
                equivalent = _hollerith[alpha];
                return true;
            }
            else
            {
                equivalent = 0;
                return false;
            }

        }


    }
}
