using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMvcValidation.Models
{
    public class User
    {
        private const string RegularExpression = @"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$";

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [RegularExpression(RegularExpression, ErrorMessage = "{0} alanı sadece büyük ve küçük harflerden oluşabilir.")]
        [MinLength(10, ErrorMessage = "{0} 10 karakterden az olamaz."), MaxLength(20, ErrorMessage = "{0} 20 karakterden fazla olamaz.")]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [RegularExpression(RegularExpression, ErrorMessage = "{0} alanı sadece büyük ve küçük harflerden oluşabilir.")]
        [MinLength(5, ErrorMessage = "{0} 5 karakterden az olamaz."), MaxLength(25, ErrorMessage = "{0} 25 karakterden fazla olamaz.")]
        [Display(Name = "Ad")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [RegularExpression(RegularExpression, ErrorMessage = "{0} alanı sadece büyük ve küçük harflerden oluşabilir.")]
        [MinLength(5, ErrorMessage = "{0} 5 karakterden az olamaz."), MaxLength(25, ErrorMessage = "{0} 25 karakterden fazla olamaz.")]
        [Display(Name = "Soyad")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [Range(18, 90, ErrorMessage = "{0} 18'den küçük ve 90'dan büyük olamaz.")]
        [Display(Name = "Yaş")]
        public int Age { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [StringLength(200, MinimumLength = 50, ErrorMessage = "{0} 50 karakterden az ve 200 karakterden fazla olamaz.")]
        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçersiz {0} girdiniz.")]
        [StringLength(50, MinimumLength = 20, ErrorMessage = "{0} 20 karakterden az ve 50 karakterden fazla olamaz.")]
        [Display(Name = "E-posta")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [Phone(ErrorMessage = "Geçersiz {0} girdiniz.")]
        [MinLength(11, ErrorMessage = "{0} 11 basamaklı olmalıdır."), MaxLength(11, ErrorMessage = "{0} 11 basamaklı olmalıdır.")]
        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [CreditCard(ErrorMessage = "Geçersiz {0} girdiniz.")]
        [MinLength(16, ErrorMessage = "{0} 16 basamaklı olmalıdır."), MaxLength(16, ErrorMessage = "{0} 16 basamaklı olmalıdır.")]
        [Display(Name = "Kredi Kartı Numarası")]
        public string CreditCard { get; set; }
    }
}