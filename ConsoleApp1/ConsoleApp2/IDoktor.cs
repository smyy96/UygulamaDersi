namespace ConsoleApp2
{
    public interface IDoktor
    {
        public Alan Alan { get; set; }
        public DateTime BaşlamaTarihi { get; set; }

        public List<Randevu> Randevular { get; set; }
    }

}
