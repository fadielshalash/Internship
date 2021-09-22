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
        public GenRepo(AppDbContext cont){
            this.cont = cont;
        }

        public void delete(int id)
        {
            var delitem = cont.Set<T>().SingleOrDefault(item => item.Id == id);
            cont.Set<T>().Remove(delitem);
            cont.SaveChanges();
        }

        public List<T> get()
        {
            return cont.Set<T>().ToList();
        }

        public T get(int id)
        {
            return cont.Set<T>().SingleOrDefault(item => item.Id == id);
        }

        public void update(T item)
        {
            
        }
        public void add(T item)
        {
            cont.Set<T>().Add(item);
            cont.SaveChanges();
        }
    }
}
