using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Globalization;

namespace Banque
{
    [Serializable]
    public class Comptes : HashSet<Compte>
    {
        
        /// <summary>
        /// Constructeur par défaut 
        /// </summary>
        public Comptes() : base() { }
        /// <summary>
        /// Chargement des comptes 
        /// sauvegardés en XML
        /// </summary>
        /// <param name="pathRepData"></param>
        public void Save(string pathRepData)
        {
            SerialiseurXML sXML = new SerialiseurXML();
            sXML.SerialiseXml(pathRepData, this);
           
        }
        /// <summary>
        /// Persistance des comptes
        /// </summary>
        /// <param name="pathRepData">Emplacement </param>
        public void Load(string pathRepData)
        {
            SerialiseurXML sXML = new SerialiseurXML();
            if (sXML.DeserialiseXml(pathRepData, this.GetType()) is Comptes comptes)
            {
                this.SymmetricExceptWith(comptes);
            }
        }       

    }

}
