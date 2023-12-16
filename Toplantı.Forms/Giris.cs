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
    public partial class Giris : Form
    {   ToplantiServis toplantıservis;
        List<Userdtos> kullanicilistesi;
        public Giris()
        {
            InitializeComponent();
            toplantıservis = new ToplantiServis();
        }

        private async void Giris_Load(object sender, EventArgs e)
        {
            await toplantıservis.Connection.StartAsync();

            toplantıservis.Connection.On<List<Userdtos>>("ReceiveUsers", userss =>
            {
                kullanicilistesi = userss;
            });
            await toplantıservis.Connection.InvokeAsync("GetUsers");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var girisdto = new Girisdto()
            {
                kullaniciadi = textkkullanici.Text,
                sifre = textsifre.Text,
            };
            ValidationContext context = new ValidationContext(girisdto);
            List<ValidationResult> errors = new List<ValidationResult>();
            if (Validator.TryValidateObject(girisdto, context, errors, true))
            {
                var user = kullanicilistesi.FirstOrDefault(x=> x.kullanıcıadı== girisdto.kullaniciadi && x.kullanıcısifre==girisdto.sifre);
                
                if(user != null)
                {
                    MessageBox.Show("Giriş başarılı. Anasayfaya yönlendiriliyorsunuz..");
                    Anasayfa anasayfa = new Anasayfa(user);
                    anasayfa.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış..");
                }
            }
            else
                MessageBox.Show(string.Join(Environment.NewLine, errors.Select(x => x.ErrorMessage)));
        }

        private void linkgiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Girispaneli girispaneli = new Girispaneli();
            girispaneli.Show();
            Hide();
        }
    }
}
