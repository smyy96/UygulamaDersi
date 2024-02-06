namespace ConsoleApp2
{
    public class Hasta : Kullanici, IHasta
    {
        public Hasta()
        {
                
        }
        public Hasta(int id ):base(id)
        {
                
        }
        public List<IRandevu> Randevular { get; set; } = new();
        public List<IHastalık> Hastalıklar { get; set; }
    }
}
