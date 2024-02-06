
namespace ConsoleApp2
{
    public class Doktor : Kullanici, IDoktor
    {

        public Doktor()
        {
                
        }

        public Doktor(int id):base(id) 
        {
                
        }
        public Alan Alan { get; set; }
        public DateTime BaşlamaTarihi { get; set; }

        public List<Randevu> Randevular { get; set; } = new();
    }

}
