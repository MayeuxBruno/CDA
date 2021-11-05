using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decouverte
{
    class Personnes
    {
        //Attributs
        private string nom;
        private string prenom;
        private int age;
        private string adresse;

     
        // Constructeurs
        public Personnes()
        {

        }
        public Personnes(string nom, string prenom, int age, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.adresse = adresse;
        }
        public Personnes(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }
        public Personnes(string nom,string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        //Accesseurs
        public string GetNom()
        {
            return this.nom;
        }
        public void SetNom(string nom)
        {
            this.nom = nom;
        }
        public string GetPrenom()
        {
            return this.prenom;
        }
        public void SetPreom(string prenom)
        {
            this.prenom = prenom;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public string GetAdresse()
        {
            return this.adresse;
        }
        public void SetAdresse(string adresse)
        {
            this.adresse = adresse;
        }

        // Autres Méthodes
        public override string ToString()
        {
            return "\n Nom : " + this.nom + "\n Prenom : " + this.prenom + "\n Age : " + this.age + "\n Adresse : " + this.adresse;
        }
    }
}
