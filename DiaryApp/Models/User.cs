using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string Login_Id { get; set; }
        [Required]
        public string Password_Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Phone { get; set; }

    }
}
