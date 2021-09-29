using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testpro.models;
namespace testpro.Repositories
{
    public class GenRepo<T> : IGenRepo<T> where T : class, IBaseModel
    {
        private readonly AppDbContext cont = null;
        public GenRepo(AppDbContext cont)
        {
            this.cont = cont;
        }

        public async Task delete(int id)
        {
            var delitem = cont.Set<T>().SingleOrDefault(item => item.Id == id);
            cont.Set<T>().Remove(delitem);
            cont.SaveChanges();
        }

        public async Task<List<T>> get()
        {
            return cont.Set<T>().ToList();
        }

        public async Task<T> get(int id)
        {
            return cont.Set<T>().SingleOrDefault(item => item.Id == id);
        }

        public async Task update(T item)
        {

        }
        public async Task add(T item)
        {
           await  cont.Set<T>().AddAsync(item);
            await cont.SaveChangesAsync();
        }
        public async Task<IEnumerable<T>> GetPage(int size, int index)
        {
            return  cont.Set<T>().Take(size).ToList().Skip(size * (index - 1));
        }
    }
}
