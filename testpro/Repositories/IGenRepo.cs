using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testpro.models;

namespace testpro.Repositories
{
    public interface IGenRepo<T> where T : class, IBaseModel
    {
        public  List<T> get();
        public T get(int id);
        public void update(T item);
        public void delete(int id);
        public void add(T item);

    }
}
