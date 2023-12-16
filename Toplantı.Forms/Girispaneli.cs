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
    public partial class Girispaneli : Form
    {   
        ToplantiServis toplantiServis;
        public Girispaneli()
        {
            InitializeComponent();
            toplantiServis = new ToplantiServis();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var kayitDto = new KayitDto
            {
                kullaniciadi = textkkullanici.Text,
                sifre = textsifre.Text,
                sifretekrar = textsifretkr.Text,

            };
            ValidationContext context = new ValidationContext(kayitDto);
            List<ValidationResult> errors = new List<ValidationResult>();


            if(Validator.TryValidateObject(kayitDto,context,errors,true))
            {
                await toplantiServis.Connection.InvokeAsync("kullaniciolustur", kayitDto);
                MessageBox.Show("Kayıt başaralı giriş ekranına yönlendiriliyorsunuz..");
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors.Select(x => x.ErrorMessage)));
            }
        }

        private async void Girispaneli_Load(object sender, EventArgs e)
        {
            await toplantiServis.Connection.StartAsync();
        }

        private void linkgiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            Hide();
        }
    }
}
