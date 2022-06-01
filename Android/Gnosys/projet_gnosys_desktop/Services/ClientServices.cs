using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using projet_gnosys.Data.Dtos;
using projet_gnosys.Listes;
using projet_gnosys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace projet_gnosys.Services
{
    class ClientServices
    {
        private const string URL = "https://gnosys.quentinbalair.fr/api/clients";
        private HttpClient client = new HttpClient();


        public async Task AddClientAsync(ClientsDTOOut obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            HttpResponseMessage response = await client.PostAsJsonAsync(URL, obj);
        }

        public async Task DeleteClientAsync(int id)
        {
            //if (id == null)
            //{
              //  throw new ArgumentNullException(nameof(id));
            //}
            await client.DeleteAsync(URL+"/"+id);
        }

        public async Task UpdateClientAsync(Client obj,int id)
        {
            await client.PutAsJsonAsync(URL +"/"+ id, obj);
        }

        public async Task<List<Client>> GetAllClientAsync()
        {
              var response = await client.GetAsync(URL);
               var json="";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/ld+json"));

                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                { 
                    json = response.Content.ReadAsStringAsync().Result;
                }
            
            
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);

            
            List<Client> ListeClients = new();
            for (int i = 0; i < myDeserializedClass.HydraMember.Count; i++)
            {
                ListeClients.Add(myDeserializedClass.HydraMember[i].CreateClient());
            }

          
            return ListeClients;
        }
    }
}
