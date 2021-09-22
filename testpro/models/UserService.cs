using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testpro.models
{
    public class UserService : IUser
    {
         List<User> Users = new List<User>(){
        new User()
            {
                DoB = DateTime.Now,
                Id = 0,
                email = "anas@gmail.com",
                name = "Anas Manassra",
                phone = "0597060876"

            },
        new User()
            {
                phone = "0597023451",
                DoB = DateTime.Today,
                name = "Johnny",
                email = "johnnysmith@gmail.com",
                Id = 2
            },
        new User()
            {
                phone = "0597032156",
                DoB = DateTime.Today,
                name = "Jack",
                email = "jack@gmail.com",
                Id = 1
            },
         new User()
            {
                phone = "0596056785",
                DoB = DateTime.Today,
                name = "Julian",
                email = "julian@gmail.com",
                Id = 3
            },
          new User()
            {
                phone = "0599085643",
                DoB = DateTime.Today,
                name = "Sara",
                email = "sara@gmail.com",
                Id = 4
            }
        };

        
       public  User get(int id)
        {
            var b = Users.FirstOrDefault(x => x.Id == id);
            return b;
        }

        public List<User> getall()
        {
            return Users;
        }

       public  void AddUser(User u)
        {
            Users.Add(u);
        }

       public  void DeleteUser(int id)
        {
            var a = Users.SingleOrDefault(x => x.Id == id);
            if (a != null)
            Users.Remove(a);
        }

    }
}
