using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Globalization;
using System.Runtime.Serialization;
using System.IO;

namespace Banque
{
    internal class SerialiseurXML
    {
        /// <summary>
        /// Méthode de sérialisation des objets métiers en XML
        /// Le document XML généré porte le nom du type sérialisé
        /// </summary>
        /// <param name="pathRepData">Chemin du répertoire</param>
        /// <param name="objetASerialiser"></param>
        internal void SerialiseXml(string pathRepData, object objetASerialiser)
        {
            Type type = objetASerialiser.GetType();
            string pathXmlDocument = string.Format("{0}\\{1}.Xml", pathRepData, type.Name);
            using (FileStream fileStream = new FileStream(pathXmlDocument, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                XmlTextWriter xmlTW = new XmlTextWriter(fileStream, Encoding.UTF8);
                XmlSerializer xmlS = new XmlSerializer(type);
                xmlS.Serialize(xmlTW, objetASerialiser);
                xmlTW.Close();
                fileStream.Close();
            }
        }
        internal object DeserialiseXml(string pathRepData, Type type)
        {
            object objet = null;

            string pathXmlDocument = string.Format("{0}\\{1}.Xml", pathRepData, type.Name);
            if (File.Exists(pathXmlDocument))
            {
                using (FileStream fileStream = new FileStream(pathXmlDocument, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    XmlTextReader xmlTR = new XmlTextReader(fileStream);
                    XmlSerializer xmlS = new XmlSerializer(type);
                    objet = xmlS.Deserialize(xmlTR);
                    xmlTR.Close();
                    fileStream.Close();
                }
            }
            return objet;
        }

    }
}
