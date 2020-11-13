using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Banque;
namespace BanqueConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            CreerComptes();
            TesterHollerith();
            Modulo();
            numeroCompte("1535922D038");
            Console.WriteLine($"{remplaceCHarParNumero("1535922D038")}");
            Console.WriteLine($"{CleRIB()}");
            Console.ReadKey();

        }

        private static void TesterHollerith()
        {
            Console.WriteLine("Test fonction de transcodage Hollerith");
            int equivalent;
            Hollerith.Transcoder('Z', out equivalent);
            Console.WriteLine($"caractere : Z valeur : {equivalent}");

           

        }

        private static void CreerComptes()
        {
            Comptes comptes = new Comptes();
            Compte compte = new Compte
            {
                CodeClient = "23456754",
                CodeBanque = "20041",
                CodeGuichet = "01006",
                Numero = "0068875R027",
                CleRIB = "70",
                LibelleCompte = "Mickaël Barrer Banque Postale"
            };
            comptes.Add(compte);
            compte = new Compte
            {
                CodeClient = "23456754",
                CodeBanque = "10907",
                CodeGuichet = "00237",
                Numero = "44219104266",
                CleRIB = "03",
                LibelleCompte = "Bost Banque Populaire courant"
            };
            comptes.Add(compte);
            compte = new Compte
            {
                CodeClient = "23456754",
                CodeBanque = "10907",
                CodeGuichet = "00237",
                Numero = "64286104261",
                CleRIB = "20",
                LibelleCompte = "Bost CASDEN"
            };
            comptes.Add(compte);
            comptes.Save(Properties.Settings.Default.BanqueAppData);

            comptes = new Comptes();
            comptes.Load(Properties.Settings.Default.BanqueAppData);
            Console.WriteLine($"{comptes.Count} comptes sont présents dans la collection");
            
            foreach (Compte item in comptes)
            {
                Console.WriteLine(item.ToString());
            }

        }
        static void Modulo()
        {
            Console.WriteLine($"Modulo 100 % 97 : {100 % 97}");
            
        }
        static void numeroCompte(string compte)
        {
            Regex Myregex = new Regex(@"[0-9]");
            Console.WriteLine( Myregex.Replace(compte, ""));
           
        }
        
        static string remplaceCHarParNumero(string Numerocompte)
        {
            int equivalent;
            char[] charArr = Numerocompte.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (char.IsLetter(charArr[i]))
                {
                    Hollerith.Transcoder(charArr[i], out equivalent);
                    //Console.WriteLine($"{equivalent}");
                    Console.WriteLine($"{charArr[i] = Convert.ToChar( equivalent.ToString())}");
                }
            }
            string result = new string(charArr);
            return result;
        }

        static int CleRIB()
        {
            double CleRIB;
            string codeBanqueTxtBox = remplaceCHarParNumero("1535922D038");
            double Cdbanque = double.Parse("20041");
            double Cdguichet = double.Parse("01007");
            double Nbcompte = Convert.ToDouble(codeBanqueTxtBox);
            
            CleRIB = 97 - (((89 * Cdbanque) + (15 * Cdguichet) + (3 * Nbcompte) )% 97);
            return Convert.ToInt32(CleRIB);
        }
    }
}