using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toplantı.Forms.DTOS;
using Toplantı.Forms.Serviss;

namespace Toplantı.Forms
{
    public partial class Toplantıolustur : Form
    {
        ToplantiServis toplantiServis;
        Userdtos kullanıcı;
        public Toplantıolustur(Userdtos kullanıcı)
        {
            InitializeComponent();
            this.kullanıcı = kullanıcı;
            toplantiServis = new ToplantiServis();
        }

        private async void Toplantıolustur_Load(object sender, EventArgs e)
        {
            await toplantiServis.Connection.StartAsync();
        }

        private async void btntopolustur_Click(object sender, EventArgs e)
        {
            var toplantıolusturdto = new ToplantiDto
            {   
                aciklama = richaciklama.Text,
                kullanıcııd = kullanıcı.kullanıcııd,
                baslik = textbaslik.Text,
                secilentarihler = new List<DateTime> { datetptarih1.Value, datetptarih2.Value },


            };
            ValidationContext context = new ValidationContext(toplantıolusturdto);
            List<ValidationResult> errors = new List<ValidationResult>();
            if (Validator.TryValidateObject(toplantıolusturdto, context, errors, true))
            {
                await toplantiServis.Connection.InvokeAsync("toplantıolustur", toplantıolusturdto);
                MessageBox.Show("Toplantı başarıyla eklendi..");
            }
            else
                MessageBox.Show(string.Join(Environment.NewLine, errors.Select(x => x.ErrorMessage)));

        }
    }
}
