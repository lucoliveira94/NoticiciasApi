using System.ComponentModel.DataAnnotations;

namespace BlogNoticias.Data.Dtos
{
    public class CreateEditorDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }

        public CreateEditorDto(string username, string cpf, string password, string repassword)
        {
            Username = username;
            CPF = cpf;
            Password = password;
            RePassword = repassword;
        }
    }
}

