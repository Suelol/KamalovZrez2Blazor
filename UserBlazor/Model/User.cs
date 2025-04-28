using System.ComponentModel.DataAnnotations;

namespace UserBlazor.Model
{
    public class User
    {
        public int id_User { get; set; }
        public string? Name { get; set; }
        public string? Descrioption { get; set;  }
        [EmailAddress(ErrorMessage = "Некорректный формат Email.")]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "Обычный пользователь";
    }
}
