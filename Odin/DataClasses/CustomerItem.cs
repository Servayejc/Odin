using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odin.DataClasses
{
    public class CustomerItem
    {
        private string m_Prenom;

        public string Prenom
        {
            get { return m_Prenom; }
            set { m_Prenom = value; }
        }
        private string m_NomFamille;

        public string NomFamille
        {
            get { return m_NomFamille; }
            set { m_NomFamille = value; }
        }
        private string m_CodeClient;

        public string CodeClient
        {
            get { return m_CodeClient; }
            set { m_CodeClient = value; }
        }
        private string m_NAS;

        public string NAS
        {
            get { return m_NAS; }
            set { m_NAS = value; }
        }
        private string m_Ville;

        public string Ville
        {
            get { return m_Ville; }
            set { m_Ville = value; }
        }
        private string m_Rue;

        public string Rue
        {
            get { return m_Rue; }
            set { m_Rue = value; }
        }
        private string m_Numero;

        public string Numero
        {
            get { return m_Numero; }
            set { m_Numero = value; }
        }
        private string m_Province;

        public string Province
        {
            get { return m_Province; }
            set { m_Province = value; }
        }
        private string m_Pays;

        public string Pays
        {
            get { return m_Pays; }
            set { m_Pays = value; }
        }
        private string m_CodePostal;

        public string CodePostal
        {
            get { return m_CodePostal; }
            set { m_CodePostal = value; }
        }

        private string m_FileName;

        public string FileName
        {
            get { return m_FileName; }
            set { m_FileName = value; }
        }
    }
}