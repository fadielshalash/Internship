using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using testpro.Repositories;
namespace testpro.models
{
    public class Post : IBaseModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string title { get; set; }
        public string body { get; set; }
        [ForeignKey("User")]
        public int userId { get; set; }
        [InverseProperty("posts")]
        public User Users { get; set; }
       // [ForeignKey("Ruser")]
      //  public int RId { get; set; }
       // [InverseProperty("posts")]
       // public User RUsers { get; set; }
    }
}
