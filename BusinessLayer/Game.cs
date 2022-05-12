using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class Game
    {
        private Game()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required] [MaxLength(20)]
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public List<Genre> Genres { get; set; }

        public Game( string name)
        {
            this.Name = name;
            this.Users = new List<User>();
            this.Genres = new List<Genre>();
        }
    }
}
