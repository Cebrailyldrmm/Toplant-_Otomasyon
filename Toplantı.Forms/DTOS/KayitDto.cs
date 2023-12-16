using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplantı.Forms.DTOS
{
    public class KayitDto
    {
        [Required(ErrorMessage ="Kullanıcı adı giriniz.")]
        public string kullaniciadi { get; set; }
        [Required(ErrorMessage = "Şifre giriniz.")]
        public string sifre { get; set; }
        [Compare("sifre", ErrorMessage = "Şifreler aynı olmalıdır.")]
        public string sifretekrar { get; set; }
    }
}
