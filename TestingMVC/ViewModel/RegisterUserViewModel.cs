using System.ComponentModel.DataAnnotations;

namespace TestingMVC.ViewModel
{
    public class RegisterUserViewModel
    {
        public string UserName { get; set;}

        [DataType(DataType.Password)]   
        public string Password { get; set;}

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string PasswordConfirmed { get; set;}

        public string Address { get; set; }

    }
}
