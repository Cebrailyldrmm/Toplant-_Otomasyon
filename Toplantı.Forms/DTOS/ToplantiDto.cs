using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplantı.Forms.DTOS
{
    public class ToplantiDto
    {
        [Required (ErrorMessage = "Başlık giriniz..")] 
        public string baslik { get; set; }
        public string kullanıcııd { get; set; }
        [Required(ErrorMessage = "Açıklama giriniz..")]
        public string aciklama { get; set; }
        public List<DateTime> secilentarihler { get; set; }
    }
}
