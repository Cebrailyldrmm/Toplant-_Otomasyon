namespace toplantıserver.Models
{
    public class toplantıss
    {
        public string toplantibasligi { get; set; }
        public string acıklama { get; set; }
        public string toplantıcode { get; set; } = Guid.NewGuid().ToString().Substring(0, 10).Replace("-", "");
        public string kulanıcııd { get; set; }
        public string toplantııd { get; set; } = Guid.NewGuid().ToString();
        public List<DateTime> tarihss { get; set; }

        public List<katılımcı> katılımcılar { get; set; }

    }
}
