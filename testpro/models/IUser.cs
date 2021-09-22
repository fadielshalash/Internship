using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testpro.models
{
    public interface IUser
    {
        User get(int id);

        List<User> getall();

        void  AddUser(User u);

        void DeleteUser(int x);
    }
}
