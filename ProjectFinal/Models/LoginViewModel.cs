using System.ComponentModel.DataAnnotations;
namespace ProjectFinal.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }
    }
}