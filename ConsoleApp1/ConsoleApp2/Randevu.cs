namespace ConsoleApp2
{
    public class Randevu : IRandevu
    {
        public DateTime RandevuTarih { get; set; }
        public RandevuStatus RandevuStatus { get; set; }
        public int RandevuID { get; set; }
    }
}
