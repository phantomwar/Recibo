using System.Threading.Tasks;
using recibo.Models;

namespace recibo.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveChangesAsync();

        Task<Recibo[]> GetAllRecibosAsync();
        Task<Recibo> GetAllRecibosAsyncbyId(int ReciboId);
    }
}