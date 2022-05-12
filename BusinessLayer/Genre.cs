using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Genre
    {
        private Genre()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; } 

        [Required]
        public string Name { get; set; }

        [ForeignKey("User")]
        public List<User> Users { get; set; }

        public Genre(string name)
        {
            this.Name = name;
            this.Users = new List<User>();
        }
    }
}
