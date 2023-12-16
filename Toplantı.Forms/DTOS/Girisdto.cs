using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplantı.Forms.DTOS
{
    public class Girisdto
    {
        [Required(ErrorMessage ="Kullanıcı adı giriniz..")]
        public string kullaniciadi { get; set; }
        [Required(ErrorMessage = "şifre giriniz..")]
        public string sifre { get; set; }
    }
}
