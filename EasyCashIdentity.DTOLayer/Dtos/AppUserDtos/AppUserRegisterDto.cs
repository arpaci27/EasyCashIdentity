using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentity.DTOLayer.Dtos.AppUserDtos
{
	public class AppUserRegisterDto
	{
        //[Required(ErrorMessage ="Ad alanı zorunludur!")]
        //[Display(Name="İsim: ")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
