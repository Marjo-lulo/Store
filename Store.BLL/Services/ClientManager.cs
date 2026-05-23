using Microsoft.EntityFrameworkCore;
using Store.BLL.Contracts;
using Store.BLL.Entites;
using Store.BLL.Entities;

namespace Store.BLL.Services
{
    internal class ClientManager : IClientManager
    {
        private readonly DbSet<DAL.Entities.Client> _clients;
        private readonly DAL.StoreDbContext _dbContext;
        public ClientManager(DAL.StoreDbContext dbContext)
        {
            _dbContext = dbContext;
            _clients = dbContext.Clients;
        }

        public ClientBLL Add(ClientBLL client)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientBLL> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClientBLL GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ClientBLL Update(int id, ClientBLL client)
        {
            throw new NotImplementedException();
        }
    }
}
