using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Anasayfa : Form
    {
        ToplantiServis toplantiServis;
        Userdtos kullanıcı;
        List<Toplantilistele> toplanti;
        List<KatilimciDto> katilimcilar;

        public Anasayfa(Userdtos kullanıcı)
        {
            InitializeComponent();
            toplantiServis = new ToplantiServis();
            this.kullanıcı = kullanıcı;
        }

        private async void Anasayfa_Load(object sender, EventArgs e)
        {   
            lblkullanici.Text= $"Hoşgeldin {kullanıcı.kullanıcıadı}" ;
            await toplantiServis.Connection.StartAsync();

            toplantiServis.Connection.On<List<Toplantilistele>>("ReceiveMeeting", toplantii=>
            {
                toplanti = toplantii;
            } );
            await toplantiServis.Connection.InvokeAsync("toplantilistele");

            toplantiServis.Connection.On<List<KatilimciDto>>("ReceiveParticipant", katılımcıı=>
            {
                katilimcilar = katılımcıı;
            });
        }

        private async void btnkatil_Click(object sender, EventArgs e)
        {
            var toplantıkod = texttoplantikod.Text;
            if (string.IsNullOrWhiteSpace(toplantıkod))
            {
                var toplantı = toplanti.FirstOrDefault(x => x.toplantıcode== toplantıkod);
                if (toplantı != null)
                {
                    await toplantiServis.Connection.InvokeAsync("kullanicial", toplantı.toplantııd);
                    if(katilimcilar.Any(x=> x.kullanıcııd == kullanıcı.kullanıcııd))
                    {
                        MessageBox.Show("toplantıya yönlendiriliyorsunuz..");
                    }
                    else
                    {
                        MessageBox.Show("Katılımcı listesinde isminiz bulunamadı");
                    }
                }

            }
            else
                MessageBox.Show("Toplantı kodunu hatalı girdiniz..");
        }

        private void btntoplantiolustur_Click(object sender, EventArgs e)
        {
            Toplantıolustur toplantıolustur = new Toplantıolustur(kullanıcı);
            toplantıolustur.Show();
            Hide();
        }

        
    }
}
