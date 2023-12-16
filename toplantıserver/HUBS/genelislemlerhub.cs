using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using toplantıserver.DTOSS;
using toplantıserver.Models;
using toplantıserver.STATİC;

namespace toplantıserver.HUBS
{
    public class genelislemlerhub : Hub
    {
        public async Task kullaniciolustur(dtokullanıcıolustur dto)
        {
            var kullanicilistesijson = System.IO.File.ReadAllText(dosyayolu.user);
            var kullanicilistesi = JsonConvert.DeserializeObject<List<kullanıcı>>(kullanicilistesijson);
            var yenikullanici = new kullanıcı
            {
                kullanıcıadı = dto.kullaniciadi,
                kullanıcısifre = dto.sifre,

            };

            kullanicilistesi.Add(yenikullanici);
            var yenikullanicilistesijson = JsonConvert.SerializeObject(kullanicilistesi);
            System.IO.File.WriteAllText(dosyayolu.user, yenikullanicilistesijson);
        }

        public async Task GetUsers()
        {
            var kullanicilistesijson = System.IO.File.ReadAllText(dosyayolu.user);
            var kullanicilistesi = JsonConvert.DeserializeObject<List<kullanıcı>>(kullanicilistesijson);
            await Clients.Caller.SendAsync("ReceiveUsers", kullanicilistesi);
        }

        public async Task toplantıolustur(toplantıolusturdtos dto)
        {
            var toplantıJson = System.IO.File.ReadAllText(dosyayolu.toplantıs);
            var toplantı = JsonConvert.DeserializeObject<List<toplantıss>>(toplantıJson);

            var yenitoplantı = new toplantıss
            {
                acıklama = dto.aciklama,
                toplantibasligi = dto.baslik,
                kulanıcııd = dto.kullanıcııd,
                tarihss = dto.secilentarihler,
                katılımcılar = new List<katılımcı>()
            };
            toplantı.Add(yenitoplantı);
            var yenitoplantıJson = JsonConvert.SerializeObject(toplantı);
            System.IO.File.WriteAllText(dosyayolu.toplantıs, yenitoplantıJson);
        }

        public async Task toplantilistele()
        {
            var toplantıJson = System.IO.File.ReadAllText(dosyayolu.toplantıs);
            var toplantı = JsonConvert.DeserializeObject<List<toplantıss>>(toplantıJson);
            await Clients.Caller.SendAsync("ReceiveMeeting", toplantı);
        }

        public async Task katılımcıekle(katılımcıekledtos dto)
        {
            var toplantıJson = System.IO.File.ReadAllText(dosyayolu.toplantıs);
            var toplantı = JsonConvert.DeserializeObject<List<toplantıss>>(toplantıJson);
            var toplanti = toplantı.FirstOrDefault(x => x.toplantııd == dto.toplantııd);

            var yenikatilimci = new katılımcı
            {
                kullanıcııd = dto.kullanıcııd,
                secilentarih = dto.secilentarih,
            };
            toplanti.katılımcılar.Add(yenikatilimci);
        }

        public async Task kullanicial(string toplantııd)
        {
            var toplantıJson = System.IO.File.ReadAllText(dosyayolu.toplantıs);
            var toplantı = JsonConvert.DeserializeObject<List<toplantıss>>(toplantıJson);
            var katilimci = toplantı.FirstOrDefault(x => x.toplantııd == toplantııd).katılımcılar;
            await Clients.Caller.SendAsync("ReceiveParticipant", katilimci);

            
        }

    }

}
