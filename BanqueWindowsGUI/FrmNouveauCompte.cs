using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Banque;
using System.Text.RegularExpressions;

namespace BanqueWindowsGUI
   
{
    /// <summary>
    /// Création d'un nouveau compte  externe à la banque
    /// </summary>
    public partial class FrmNouveauCompte : Form
    {
        Comptes listeComptes;
        private const string CodeClient= "23456754";
        public FrmNouveauCompte()
        {
            InitializeComponent();
        }

        public FrmNouveauCompte(Comptes comptes) :this()
        {
            listeComptes = comptes;
        }

        private void FrmNouveauCompte_Load(object sender, EventArgs e)
        {
            listeComptes = new Comptes();
            listeComptes.Load(Properties.Settings.Default.BanqueAppData);
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {

            // Pour ne pas sortir du dialog avec DialogResult.OK
            // Lorsque des erreurs subsistent 
            // Utiliser this.DialogResult = DialogResult.None
            try
            {
                this.DialogResult = DialogResult.None;
                ErpSaisi.Clear();
                if (string.IsNullOrEmpty(codeBanqueTextBox.Text) || Regex.IsMatch(codeBanqueTextBox.Text, @"[0-9]") == false)
                {

                    ErpSaisi.SetError(codeBanqueTextBox, "la valeur champ code Banque n'est pas valide");


                }
                if (string.IsNullOrEmpty(codeGuichetTextBox.Text) || Regex.IsMatch(codeGuichetTextBox.Text, @"[0-9]") == false)
                {
                    ErpSaisi.SetError(codeGuichetTextBox, "la valeur du champ code Guichet n'est pas valide");

                }
                if (string.IsNullOrEmpty(numeroCompteTextBox.Text) || Regex.IsMatch(numeroCompteTextBox.Text, @"^[a-zA-Z0-9]+$") == false)
                {
                    ErpSaisi.SetError(numeroCompteTextBox, "la valeur du champ numero de compte n'est pas valide");

                }
                if (string.IsNullOrEmpty(cleRIBTextBox.Text) || Regex.IsMatch(cleRIBTextBox.Text, @"[0-9]") == false)
                {
                    ErpSaisi.SetError(cleRIBTextBox, "la valeur du champ cle RIB n'est pas valide");
                }
                if (string.IsNullOrEmpty(libellécompteTextBox.Text))
                {
                    ErpSaisi.SetError(libellécompteTextBox, "la valeur du libellé du compte ne peut pas être vide");
                }
                else
                {
                    Compte nouveauCompte = new Compte();
                    if (codeBanqueTextBox.Text.Length < 5 || codeGuichetTextBox.Text.Length < 5 || numeroCompteTextBox.Text.Length < 11)
                    {
                        codeBanqueTextBox.Text = completerParZiro(codeBanqueTextBox.Text, 5);
                        codeGuichetTextBox.Text = completerParZiro(codeGuichetTextBox.Text, 5);
                        numeroCompteTextBox.Text = completerParZiro(numeroCompteTextBox.Text, 11);

                    }
                    this.DialogResult = DialogResult.OK;
                    AjouterCompte(nouveauCompte);
                    MessageBox.Show("Le compte a été créé avec succès!", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
            
            
           
        }

        private void BtnAbandonner_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Ajouter un nouveau compte
        /// </summary>
        /// <param name="nouveauCompte"></param>
        private void AjouterCompte(Compte nouveauCompte)
        {
            nouveauCompte.CodeBanque = codeBanqueTextBox.Text;
            nouveauCompte.CodeGuichet = codeGuichetTextBox.Text;
            nouveauCompte.CodeClient = CodeClient;
            nouveauCompte.CleRIB = CleRIB().ToString();
            nouveauCompte.LibelleCompte = libellécompteTextBox.Text;

            listeComptes.Add(nouveauCompte);
            listeComptes.Save(Properties.Settings.Default.BanqueAppData);

        }
        /// <summary>
        /// Compléter les codes par 0 si n'ont pas la taille
        /// </summary>
        /// <param name="texte"></param>
        /// <param name="LenMax"></param>
        /// <returns></returns>
        private string completerParZiro(string texte, int LenMax)
        {
            int taille = texte.Length;
            int reste = LenMax - taille;
            string serie = new String('0', reste);
            return serie + texte;
        }
        /// <summary>
        /// methede pour Calcule de la clé
        /// </summary>
        /// <returns></returns>
        private int CleRIB()
        {
            double CleRIB;
            string codeBanqueTxtBox = remplaceCHarParNumero(numeroCompteTextBox.Text);
            double Cdbanque = double.Parse(codeBanqueTextBox.Text);
            double Cdguichet = double.Parse(codeGuichetTextBox.Text);
            double Nbcompte = Convert.ToDouble(codeBanqueTxtBox);

            CleRIB = 97 - (((89 * Cdbanque) + (15 * Cdguichet) + (3 * Nbcompte)) % 97);
            return Convert.ToInt32(CleRIB);
        }
       
        
       /// <summary>
       /// methode pour remplacer les lettres par chiffre
       /// </summary>
       /// <param name="Numerocompte"></param>
       /// <returns></returns>
        private string remplaceCHarParNumero(string Numerocompte)
        {
            int equivalent;
            char[] charArr = Numerocompte.ToCharArray();
            for(int i = 0; i < charArr.Length; i++ )
            {
                if(char.IsLetter(charArr[i]))
                {
                    Hollerith.Transcoder(charArr[i], out equivalent);
                    charArr[i]= Convert.ToChar(equivalent.ToString());
                }
            }
            string result = new string(charArr);
            return result;
        }
        /// <summary>
        /// Assigner la valeur de la clé RIB calculer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numeroCompteTextBox_Validating(object sender, CancelEventArgs e)
        {
            cleRIBTextBox.Text = CleRIB().ToString();
        }
    }
}
