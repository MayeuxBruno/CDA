using Newtonsoft.Json;
using projet_gnosys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_gnosys.Models

{
    public class HydraMember
    {
        [JsonProperty("@id")]
        public string Id; 

        public void setId(String id)
        {
            int index = id.LastIndexOf("/")+1;
            this.Id = id.Substring(index);
        }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("nom")]
        public string Nom { get; set; }

        [JsonProperty("prenom")]
        public string Prenom { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("adresse")]
        public string Adresse { get; set; }

        [JsonProperty("ville")]
        public string Ville { get; set; }

        [JsonProperty("codePostal")]
        public string CodePostal { get; set; }

        [JsonProperty("numerosTelephone")]
        public string NumerosTelephone { get; set; }

        [JsonProperty("genre")]
        public string Genre { get; set; }

        [JsonProperty("isParticulier")]
        public bool IsParticulier { get; set; }

        public Client CreateClient()
        {
            Client newClient = new Client();
            int index = this.Id.LastIndexOf("/") + 1;
            newClient.Id = int.Parse(this.Id.Substring(index));
            newClient.Genre = this.Genre;
            newClient.Nom = this.Nom;
            newClient.Prenom = this.Prenom;
            newClient.Email = this.Email;
            newClient.Adresse = this.Adresse;
            newClient.CodePostal = this.CodePostal;
            newClient.Ville = this.Ville;
            newClient.IsParticulier = this.IsParticulier;
            newClient.NumerosTelephone = this.NumerosTelephone;
            return newClient;
        }
    }

    
}
