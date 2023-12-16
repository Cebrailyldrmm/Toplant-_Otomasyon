namespace toplantıserver.STATİC
{
    public static class dosyayolu
    {   
        public static string toplantıs = Path.Combine(Directory.GetCurrentDirectory(),"Data", "toplantı.json");
        public static string user = Path.Combine(Directory.GetCurrentDirectory(),"Data", "user.json");
    }
}
