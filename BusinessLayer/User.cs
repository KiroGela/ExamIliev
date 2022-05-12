using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class User
    {
        private User()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(20)]
        public string Surname { get; set; }
        [Required]
        [Range(10, 80)]
        public int Age { get; set; }
        [Required][MaxLength(20)]
        public string Username { get; set; }
        [Required][MaxLength(70)]
        public string Password { get; set; }
        [Required][MaxLength(20)]
        public string Email { get; set; }
        public List<User> Friends { get; set; } 
        public List<Genre> Games { get; set; }

        public User(string name, string surname, int age, string username, string password, string email)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Friends = new List<User>();
            this.Games = new List<Genre>();
        }
    }
}
