using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using recibo.Models;

namespace recibo.Data
{
    public class Repository : IRepository
    {
       public DataContext _context {get; }

        public Repository(DataContext context){
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public async Task<Recibo[]> GetAllRecibosAsync()
        {
            IQueryable<Recibo> query = _context.Recibos;
            query=query
                    .AsNoTracking()
                    .OrderBy(a=>a.Id);
            return await query.ToArrayAsync();
        }

        public async Task<Recibo> GetAllRecibosAsyncbyId(int ReciboId)
        {
            IQueryable<Recibo> query = _context.Recibos;
            query=query
                    .AsNoTracking()
                    .OrderBy(a=>a.Id)
                    .Where(recibo => recibo.Id == ReciboId);
            return await query.FirstOrDefaultAsync();
        }
    }
}