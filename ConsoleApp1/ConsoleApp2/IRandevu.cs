namespace ConsoleApp2
{
    public interface IRandevu
    {
     
        public int RandevuID { get; set; }
        public DateTime RandevuTarih { get; set; }
        public RandevuStatus RandevuStatus { get; set; }
      
    }
}
