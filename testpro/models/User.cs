using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testpro.Repositories;
namespace testpro.models
{
    public class User : IBaseModel
    {
       /*  public User()
        {
        } */

       /* public User(int Id)
        {
            this.Id = Id;
        } */

        public int Id { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime DoB { get; set; }
        public string  name { get; set; }
        public int age { get; set; }
        public ICollection<Post> posts { get; set; }
        // public ICollection<Post> Rposts { get; set; }
    }
}
