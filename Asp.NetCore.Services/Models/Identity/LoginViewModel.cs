using Asp.NetCore.Services.Attributes;
using System.ComponentModel.DataAnnotations;
using RangeAttribute = Asp.NetCore.Services.Attributes.RangeAttribute;

namespace Asp.NetCore.Services.Models.Identity
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter the username")]
        [Range(4, 50)]
        [NoWhiteSpaces]
        [StartWithLetter]
        [EnglishChars]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Please enter the password")]
        [Range(6, 30)]
        [NoWhiteSpaces]
        [StartWithLetter]
        [AtLeastOneNumber]
        [AtLeastOneSpecialCharacter]
        [AtLeastOneUppercaseLetterOneLowercaseLetter]
        public string? Password { get; set; }

        public bool RememberMe { get; set; } = false;

        public string? ReturnUrl { get; set; }
    }
}
