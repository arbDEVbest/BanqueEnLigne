using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Banque
{
    /// <summary>
    /// Compte en banque
    /// </summary>
    public class Compte
    {
        #region Champs
        private string _codeClient;
        private string _codeBanque;
        private string _codeGuichet;
        private string _numero;
        private string _cleRIB;
        private string _libelleCompte;


        #endregion
        #region Propriétés
        public string CodeClient
        {
            get { return _codeClient; }
            set { _codeClient = value; }
        }
        public string CodeBanque
        {
            get { return _codeBanque; }
            set { _codeBanque = value; }
        }
        public string CodeGuichet
        {
            get { return _codeGuichet; }
            set { _codeGuichet = value; }
        }

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public string CleRIB
        {
            get { return _cleRIB; }
            set { _cleRIB = value; }
        }
        public string LibelleCompte
        {
            get { return _libelleCompte; }
            set { _libelleCompte = value; }
        }
        #endregion
        /// <summary>
        /// Chaine représentant l'objet instancié.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, @"{0};{1};{2};{3};{4};{5}", this.CodeClient, this.CodeBanque, this.CodeGuichet, this.Numero, this.CleRIB, this.LibelleCompte);
        }
        /// <summary>
        /// Deux comptes sont égaux si codes client,Banque,Guichet et Numéros de compte
        /// sont identiques 
        /// </summary>
        /// <returns>Vrai si les deux objets sont égaux</returns>
        public override bool Equals(Object compte)
        {
            Compte compteRef = compte as Compte;
            if (compteRef == null) return false;
            return compteRef.CodeClient == CodeClient
                      && compteRef.CodeBanque == CodeBanque
                      && compteRef.CodeGuichet == CodeGuichet
                     && compteRef.Numero == Numero;
        }

        public override int GetHashCode()
        {
            int hashCode;
            hashCode = string.IsNullOrEmpty(_codeClient) ? 0 : _codeClient.GetHashCode();
            hashCode = string.IsNullOrEmpty(_codeBanque) ? hashCode : hashCode ^ _codeBanque.GetHashCode();
            hashCode = string.IsNullOrEmpty(_codeGuichet) ? hashCode : hashCode ^ _codeGuichet.GetHashCode();
            hashCode = string.IsNullOrEmpty(_numero) ? hashCode : hashCode ^ _numero.GetHashCode();
            return hashCode;
        }
        /// <summary>
        /// opérateur relationnel ==
        /// </summary>
        /// <param name="compteA">Instance Compte</param>
        /// <param name="compteB">Instance Compte</param>
        /// <returns>Vrai si égaux</returns>
        public static bool operator ==(Compte compteA, Compte compteB)
        {
            if (compteA is null) return compteB is null;
            return compteA.Equals(compteB);
        }
        /// <summary>
        ///  opérateur relationnel !=
        /// </summary>
        /// <param name="compteA">Instance Compte</param>
        /// <param name="compteB">Instance Compte</param>
        /// <returns>Vrai si différents</returns>
        public static bool operator !=(Compte compteA, Compte compteB)
        {
            if (compteA is null) return (object)compteB != null;
            return !compteA.Equals(compteB);
        }
    }
}
