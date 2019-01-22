using System.ComponentModel.DataAnnotations;

namespace aiguoguo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}