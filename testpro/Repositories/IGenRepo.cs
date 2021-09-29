using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testpro.models;

namespace testpro.Repositories
{
    public interface IGenRepo<T> where T : class, IBaseModel
    {
        public  Task<List<T>> get();
        public Task<T> get(int id);
        public Task update(T item);
        public Task delete(int id);
        public Task add(T item);
        public Task<IEnumerable<T>> GetPage(int size, int index);
    }
}
