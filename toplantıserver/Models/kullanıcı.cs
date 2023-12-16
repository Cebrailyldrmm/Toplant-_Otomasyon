namespace toplantıserver.Models
{
    public class kullanıcı
    {
        public string kullanıcııd { get; set; } = Guid.NewGuid().ToString();
        public string kullanıcıadı { get; set; }
        public string kullanıcısifre { get; set; }

    }
}
