using Garage.Data;
using Garage.Data.Models;
using Garage.Data.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage.Data.Services
{
    public class ClientsServices
    {
        private readonly MyDbContext _context;
        public ClientsServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddClient (Client client)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }
            _context.Add(client);
            _context.SaveChanges();
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _context.Clients.ToList();
        }
    }
}
