using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlog.ViewModels
{
    public class AuthLogin
    {
       // [Required]/*Girilmesi Zorunlu*/
        [MaxLength(5,ErrorMessage ="En az 5 Karakter olmalıdır")]/*En Fazla 5 karakter*/
        [MinLength(3)]/*En az 3 karakter*/
        [Display(Name = "User Name")]
        [Required(ErrorMessage ="Please Enter User Name")]
        public string UserName { get; set; }

        [Required]/*Girilmesi Zorunlu*/
      /*  [MaxLength(5)]/*En Fazla 5 karakter
        [MinLength(3)]/*En az 3 karakter
        [Display(Name = "Please Ente User Name")]*/
        [DataType(DataType.Password)]/*Parolanın Gözükmemesi için*/
        public  string Password { get; set; }

        public string Test { get; internal set; }
    }
}